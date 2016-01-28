using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManager : MonoBehaviour
{
	public static float time;        // The player's tim.
	public PlayerHealth playerHealth;// Reference to the player's health.

	Text timer;                      // Reference to the Text component.
	
	void Awake ()
	{
		timer = GetComponent <Text> ();
		time = 0f;
	}
	
	void Update ()
	{
		if(ScoreManager.score > 0 && playerHealth.currentHealth > 0){
			time += Time.deltaTime;
			timer.text = "Time: " + (int)time;
		}
	}
}