using UnityEngine;
using System.Collections;

public class SimpleBGMoveDown : MonoBehaviour {
	
	public float speed = 10.0f;
	private Vector3 direction;
	
	// Use this for initialization
	void Start () {
		direction = new Vector3(0.0f, 1.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position -= direction*speed*Time.deltaTime;
	}
}
