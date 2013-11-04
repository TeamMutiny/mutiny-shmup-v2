using UnityEngine;
using System.Collections;

public class OutOfBoundsController : MonoBehaviour {
	
	public float min_y = -20.0f;
	public float max_y = 50.0f;
	public float min_x = -20.0f;
	public float max_x = 20.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// check out of bounds
		if(gameObject.transform.position.y > max_y ||
			gameObject.transform.position.y < min_y ||
			gameObject.transform.position.x > max_x ||
			gameObject.transform.position.x < min_x) {
			Destroy(gameObject);
		}
	}
}
