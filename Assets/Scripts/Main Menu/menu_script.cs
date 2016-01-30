using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
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
		EditorUtility.DisplayDialog("Credits: ", "Project for WdPG\n\nAuthors: Alan Kaliński, Bartosz Cieślar, " +
			"Bartłomiej Juroszek, Maciej Toborek\nPGK UŚ 2015/2016\n\nThanks to: Adobe, Bumstrum, Aquarius Max, " +
			"Perlind Arts, Phil Chu for sharing free assets and to Unity Team for great documentation and tutorials!", "Close");
	}

	public void exitGame(){
		Application.Quit();
	}
}
