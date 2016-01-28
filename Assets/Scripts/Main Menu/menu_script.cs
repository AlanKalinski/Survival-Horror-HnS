using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menu_script : MonoBehaviour {

	public Button playButton;
	public Button creditsButton;
	public Button exitButton;

	// Use this for initialization
	void Start () {

		playButton = playButton.GetComponent<Button>();
		creditsButton = creditsButton.GetComponent<Button>();
		exitButton = exitButton.GetComponent<Button>();
		Cursor.visible = true;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startGame(){
		Application.LoadLevel("level_01");
	}

	public void credits(){
		//credits
	}

	public void exitGame(){
		Application.Quit();
	}
}
