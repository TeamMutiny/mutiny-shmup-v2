using UnityEngine;
using System.Collections;

public class CollisionControler : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "bullet" || other.gameObject.tag == "Player") {
			
			GameObject explosion = Resources.Load("Enemy explosion") as GameObject;
			Instantiate (explosion,transform.position,transform.rotation);
			GameObject foo = GameObject.Find("GUI Text");
			Destroy(explosion, 2);
			Destroy(gameObject);
			foo.SendMessage("tappo");
		}
	}
}
