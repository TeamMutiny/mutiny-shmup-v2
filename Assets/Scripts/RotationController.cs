using UnityEngine;
using System.Collections;

public class RotationController : MonoBehaviour {

	public float speed = 15.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate(new Vector3(0.25f,0.5f,0.75f) * Time.deltaTime * speed);
	}
}
