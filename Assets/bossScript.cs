using UnityEngine;
using System.Collections;

public class bossScript : MonoBehaviour {
	
	
	private GameObject boss;
	private float time;
	// Use this for initialization
	void Start () {
		boss = GameObject.Find("BOSS");
		time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

	}
	
	void moveIn(){
		
		boss.transform.position = (new Vector3(boss.transform.position.x,time,boss.transform.position.z)); 
	}
}
