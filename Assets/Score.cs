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
		if(score > 0){
		GameObject foo = GameObject.Find("Score");
		foo.guiText.text = "Score: " + score;
		}
	}
	
	void tappo(){
		score++;
	}
	
}
