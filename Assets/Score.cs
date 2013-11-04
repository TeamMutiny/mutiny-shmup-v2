using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	private int score;
	// Use this for initialization
	void Start () {
		score = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject foo = GameObject.Find("GUI Text");
		foo.guiText.text = "Kills: " + score;
	}
	
	void tappo(){
		score++;
	}
	
}
