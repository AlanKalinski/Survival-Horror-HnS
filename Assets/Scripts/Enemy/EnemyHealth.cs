using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int startingHealth = 100;            // The amount of health the enemy starts the game with.
	public int currentHealth;                   // The current health the enemy has.
	public AudioClip deathClip;                 // The sound to play when the enemy dies.

	Animator anim;                              // Reference to the animator.
	AudioSource enemyAudio;                     // Reference to the audio source.
	ParticleSystem hitParticles;                // Reference to the particle system that plays when the enemy is damaged.
	CapsuleCollider capsuleCollider;            // Reference to the capsule collider.
	bool isDead;                                // Whether the enemy is dead.

	void Awake ()
	{
		anim = GetComponent <Animator> ();
		enemyAudio = GetComponent <AudioSource> ();
		hitParticles = GetComponentInChildren <ParticleSystem> ();
		capsuleCollider = GetComponent <CapsuleCollider> ();

		currentHealth = startingHealth;
	}

	public void TakeDamage (int amount, Vector3 hitPoint)
	{
		if(isDead) return;

		enemyAudio.Play ();
		currentHealth -= amount;

		hitParticles.transform.position = hitPoint;
		hitParticles.Play();

		if(currentHealth <= 0)
		{
			Death ();
		}
	}

	void Death ()
	{
		isDead = true;
		capsuleCollider.isTrigger = true;
		anim.SetTrigger ("Dead");

		enemyAudio.clip = deathClip;
		enemyAudio.Play ();
		StartSinking();
	}
	
	
	void StartSinking ()
	{
		GetComponent <NavMeshAgent> ().enabled = false;
		GetComponent <Rigidbody> ().isKinematic = true;
		gameObject.layer = 1;
		ScoreManager.score--;
		Destroy (gameObject, 5f);
	}
}