using UnityEngine;
using System.Collections;

public class ShootInDirection : MonoBehaviour {
	
	public GameObject bullet;
	
	void shootInDirection(Vector3 direction) {
		GameObject newbullet = (GameObject)Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
		newbullet.SendMessage("setDirection", direction);
	}
	
	void shootAtPlayer() {
	
		GameObject newbullet = (GameObject)Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
		
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		
		if(player != null) {
			newbullet.transform.LookAt(player.transform.position);
		}
	}
}



