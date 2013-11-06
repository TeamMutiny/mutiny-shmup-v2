using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {
	
	private float time;
	public float bossTime = 2.0f;
	public GameObject bossObject;
	public float warningTime;
	private GameObject boss = null;
	private GameObject warning;
	// Use this for initialization
	void Start () {
		time = 0;


	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		//Debug.Log(time);
		if(time > bossTime && boss == null){
			Destroy(GameObject.Find("Spawner"));
			boss = (GameObject) Instantiate(bossObject, new Vector3(0.0f,50.0f,-4.0f), Quaternion.identity);
			boss.transform.Rotate(new Vector3(0.0f,180.0f,180.0f));
			warning = GameObject.Find("Warning");
			warning.transform.position = new Vector3(0.5f,0.4851f,0f);
			Destroy(warning, warningTime);
		}
		
	}
}
