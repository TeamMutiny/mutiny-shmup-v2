using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {
	
	public float speed = 5.0f;
	private Vector3 direction;

	// Use this for initialization
	void Start () {
		direction = new Vector3(0.0f,-speed,0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += direction*Time.deltaTime;
	}
}
