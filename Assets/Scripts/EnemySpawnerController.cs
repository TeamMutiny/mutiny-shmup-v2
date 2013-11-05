using UnityEngine;
using System.Collections;

public class EnemySpawnerController : MonoBehaviour {
	
	public GameObject basic_enemy;
	
	
	public float spawnInterval;
	public float seqTime = 10.0f;
	public float seqInterval = 3.0f;
	
	private float timer = 0.0f;
	
	public int spawnAmount = 10;
	private int spawned = 0;
	
	private Quaternion enemy_rotation = Quaternion.identity;
	
	private enum State {
		SPAWNING,
		STOPPED,
		SEQ_INTERVAL
	}
	
	private State state;
	
	// Use this for initialization
	void Start () {
		GameObject groupped =  GameObject.Find("SpawnerGroup");
		SpawnerGroupScript scripta = groupped.GetComponent<SpawnerGroupScript>();
		spawnInterval = scripta.spawnInterval;
		state = State.SPAWNING;
		
		// set enemyrotation through script
		enemy_rotation.eulerAngles = new Vector3(180.0f, 0.0f,0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
		
		switch(state) {
		
		case State.STOPPED:
			
		break;
			
		case State.SEQ_INTERVAL:
			
			if(timer > seqInterval) {
				state = State.SPAWNING;
				timer = 0.0f;
			}
		break;
			
		case State.SPAWNING:
		
			if (timer > spawnInterval/10) 
			{
				timer = 0.0f;
				GameObject newenemy = (GameObject) Instantiate(basic_enemy, gameObject.transform.position, enemy_rotation);
					
				spawned++;
				
				if(spawned >= spawnAmount) {
					spawned = 0;
					state = State.SEQ_INTERVAL;
				}
			}
			
		break;
		}
				
		timer += Time.deltaTime;
	}
}
