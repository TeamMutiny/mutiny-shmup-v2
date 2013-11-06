using UnityEngine;
using System.Collections;

public class EnemySpawnerController : MonoBehaviour {
	
	public GameObject basic_enemy;
	public GameObject anim_wrapper;
	
	private float spawnInterval;
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
		GameObject groupped =  GameObject.Find("Spawner");
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
				
				// location_wrapper moves the animation to correct position 
				GameObject animation_wrapper = (GameObject) Instantiate(anim_wrapper, new Vector3(0.0f,-20.0f,0.0f), Quaternion.identity);
				
				GameObject newenemy = (GameObject) Instantiate(basic_enemy, new Vector3(gameObject.transform.position.x,-20.0f,gameObject.transform.position.z), enemy_rotation);
				
				newenemy.transform.parent = animation_wrapper.transform;
				
				newenemy.transform.parent.animation.Play("ExpEnterExpExit");	
				
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
