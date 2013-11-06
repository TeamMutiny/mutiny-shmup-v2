using UnityEngine;
using System.Collections;

public class blink : MonoBehaviour {
	
	private float time;
	public float flashInterval = 0.5f;
	private GameObject text;
	
	// Use this for initialization
	void Start () {
		time = 0.0f;
		text = GameObject.Find("Text");
	}
	
	// Update is called once per frame
	void Update () {
			FlashLabel();
	time += Time.deltaTime;
	}
	
void FlashLabel(){
		//Debug.Log(time);
	  if (time > flashInterval) {
			
	    if(text.activeInHierarchy){
			text.SetActive(false);				
			}
		else{
			text.SetActive(true);
		}
			time = 0.0f;
	  }
		
	}
	


}
