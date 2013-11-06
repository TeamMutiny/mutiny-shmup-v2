using UnityEngine;
using System.Collections;

public class EnemyProjectileOneWay : MonoBehaviour {
	
	public float speed = 5.0f;
	private Vector3 direction;

	// Use this for initialization
	void Start () {
		direction = new Vector3(0.0f,0.0f,speed); // Default behavior
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(direction*Time.deltaTime);
	}

	void setDirection(Vector3 rotation) {
		Quaternion direction = new Quaternion();
		direction.eulerAngles = rotation;
		
		gameObject.transform.rotation = direction;	
	}
}
