using UnityEngine;
using System.Collections;

public class HPbar : MonoBehaviour {
	
	public float hp = 100;
	GameObject ship;
	Color HPcolor;
	// Use this for initialization
	void Start () {
		ship = GameObject.Find("HP bar");
		HPcolor = new Color();
		HPcolor.a = 1;
		HPcolor.b = 0;
		HPcolor.g = 0;
		HPcolor.r = 1;
		
	}
	
	// Update is called once per frame
	void Update () {
		HPcolor.r = hp/100;
		if(hp < 10){
			HPcolor.r = 0.1f;			
		}
		ship.renderer.material.SetColor("_Color",HPcolor);
	}	
	
	void GotHit(float damage){		
		hp -= damage;
		if(hp < 0){
			Destroy(GameObject.Find("spaceship"));		
		}
	}
	
	
}
