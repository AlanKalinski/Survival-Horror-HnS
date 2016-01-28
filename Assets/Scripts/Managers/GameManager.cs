using UnityEngine;

public class GameManager : MonoBehaviour
{
	public PlayerHealth playerHealth;       // Reference to the player's health.
	public float restartDelay = 5f;         // Time to wait before restarting the level
	public float changeLevelDelay = 10f;    // Time to wait before changing the level
	
	
	Animator anim;                          // Reference to the animator component.
	float restartTimer;                     // Timer to count up to restarting the level

	
	void Awake ()
	{
		anim = GetComponent <Animator> ();
		Cursor.visible = false;
	}
	
	
	void Update (){
		/* Restart level if player die */
		if(playerHealth.currentHealth <= 0){
			anim.SetTrigger ("GameOver");
			restartTimer += Time.deltaTime;
			if(restartTimer >= restartDelay)
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}

		/* Change to next level if all zombies are killed */
		if(ScoreManager.score <= 0){
			anim.SetTrigger("EndLevel");
			restartTimer += Time.deltaTime;
			if(restartTimer >= changeLevelDelay) Application.LoadLevel(Application.loadedLevel + 1);
		}
	}
}