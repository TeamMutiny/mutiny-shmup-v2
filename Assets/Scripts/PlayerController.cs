using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private CharacterController playerController;
	GameObject alus;
	public float speed;
	public float rotationSpeed = 10.0f;
	private float maxRotation = 50;
	private float maxX = 25;
	private float minX = -25;
	private Vector3 moveDirection;
	
	// Use this for initialization
	void Start () {
		alus = GameObject.Find("spaceship");
		moveDirection = new Vector3(0.0f,0.0f,0.0f);
		
		playerController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
		moveDirection *= speed;
		if((alus.transform.localPosition.x > maxX && Input.GetAxis("Horizontal") > 0 ) || (alus.transform.localPosition.x < minX && Input.GetAxis("Horizontal") < 0 )){ 
			moveDirection.Set(0,moveDirection.y,moveDirection.z);
		
		}
		playerController.Move(moveDirection * Time.deltaTime);
		float rotation = rotationSpeed *Input.GetAxis("Horizontal");
		
		if((alus.transform.rotation.y < 0.50 && Input.GetAxis("Horizontal") < 0) || (alus.transform.rotation.y > -0.50 && Input.GetAxis("Horizontal") > 0)){ 
		rotation = rotationSpeed *Input.GetAxis("Horizontal");
		alus.transform.Rotate(new Vector3(0,-rotation,0));	
		}
		if(Input.GetAxis("Horizontal") == 0){
			if(alus.transform.rotation.y > 0 ){
			rotation = rotationSpeed * -1;
			}else{
				rotation = rotationSpeed;
				
			}
			alus.transform.Rotate(new Vector3(0,rotation,0));
			
		}
		// alus.transform.rotation.y > -0.50
			
		
		
	}
}
