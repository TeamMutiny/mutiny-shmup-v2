using UnityEngine;
using System.Collections;

public class PlayerShootingScript : MonoBehaviour {
	
	// Use as a prefab
	public GameObject playerProjectile;
	public float ShotInterval = 1.0f;
	private float timeSinceShot = 0.0f;
	private Transform projectileTransform;
	
	void Start() {
		projectileTransform = transform;	
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1") && timeSinceShot > ShotInterval/10) {			
			GameObject pr = (GameObject) Instantiate(playerProjectile, projectileTransform.position, Quaternion.identity);
			pr.SendMessage("setSpeed",new Vector3(0.0f,0.5f,0.0f));
			timeSinceShot = 0;
		}else{
			timeSinceShot += Time.deltaTime;		
		}
		
	}
}

