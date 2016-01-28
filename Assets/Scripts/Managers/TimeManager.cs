using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManager : MonoBehaviour
{
	public static float time;        // The player's tim.

	Text timer;                      // Reference to the Text component.
	
	void Awake ()
	{
		timer = GetComponent <Text> ();
		time = 0f;
	}
	
	void Update ()
	{
		time += Time.deltaTime;
		timer.text = "Time: " + (int)time;
	}
}