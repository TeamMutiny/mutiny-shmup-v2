using UnityEngine;
using System.Collections;

public class infiniteScroll : MonoBehaviour {
	
	
	private GameObject BG1;
	private GameObject BG2;
	private float yAxis = 0.0f;
	
	// Use this for initialization
	void Start () {
		BG1 = GameObject.Find("background1");
		BG2 = GameObject.Find("background2");
		yAxis = BG2.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		
		
		//Debug.Log(BG2.transform.position.y);
		//Debug.Log((yAxis-165));
		if(BG2.transform.position.y < (yAxis-165)){
			BG1.transform.position = new Vector3(BG2.transform.position.x, BG2.transform.position.y+165,BG2.transform.position.z); 
			GameObject temp = BG1;
			BG1	=	BG2;
			BG2	=	temp;
			yAxis = BG2.transform.position.y;
		}
	}
}
