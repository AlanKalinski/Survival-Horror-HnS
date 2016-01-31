using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Button playButton;
	public Button creditsButton;
	public Button exitButton;
	public Button exitCredits;
	public Canvas creditsCanvas;

	// Use this for initialization
	void Start () {

		playButton = playButton.GetComponent<Button>();
		creditsButton = creditsButton.GetComponent<Button>();
		exitButton = exitButton.GetComponent<Button>();
		exitCredits = exitCredits.GetComponent<Button>();
		creditsCanvas = creditsCanvas.GetComponent<Canvas>();
		creditsCanvas.enabled = false;
		Cursor.visible = true;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startGame(){
		Application.LoadLevel("level_01");
	}

	public void credits(){
		creditsCanvas.enabled = true;		
	}

	public void closeCredits(){
		creditsCanvas.enabled = false;
	}

	public void exitGame(){
		Application.Quit();
	}
}
