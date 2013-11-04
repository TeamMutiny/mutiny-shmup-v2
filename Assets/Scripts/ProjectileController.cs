using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {
	
	private Vector3 direction;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(direction);
		if(transform.position.y > 20.0f) {
			Destroy(gameObject);
		}
	}
	
	void setSpeed(Vector3 dir) {
		direction = dir;
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Enemy") {
			Destroy(gameObject);
		}
	}
}
