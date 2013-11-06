using UnityEngine;
using System.Collections;

public class SpawnerGroupController : MonoBehaviour {
	
	public float waveInterval = 5.0f;
	private float timePassed;
	private GameObject spawni;
	
	
	private enum Sequences {onePass, zigzag, leftRow, rightRow, middleRow, reversePass}
	
	Sequences GetRandomEnum(){
	    System.Array A = System.Enum.GetValues(typeof(Sequences));
	    Sequences V = (Sequences)A.GetValue(UnityEngine.Random.Range(0,A.Length));
	    return V;
	}
	
	// Use this for initialization
	void Start () {
		timePassed = 600;
		spawni =  GameObject.Find("SpawnerGroup");
	}
	
	// Update is called once per frame
	void Update () {
		
		timePassed += Time.deltaTime;
		
		//Debug.Log(timePassed);
		
		Sequences seq = GetRandomEnum();
		if(timePassed > 10){
			
			switch(seq){
			case Sequences.onePass:
				
				spawni.animation.Play("one pass");
			//	Debug.Log("one pass");
				break;
			
			case Sequences.zigzag:
				spawni.animation.Play("Zigzag");
			//	 Debug.Log("Zigzag");
				break;
			case Sequences.leftRow:
				spawni.animation.Play("Left row");
			//	Debug.Log("Left row");
				break;
				
			case Sequences.rightRow:
				spawni.animation.Play("Right row");
			//	Debug.Log("Right row");
				break;
				
			case Sequences.middleRow:
				spawni.animation.Play("Middle row");
			//	Debug.Log("Middle row");
				break;
			
			
			case Sequences.reversePass:
				//spawni.animation.Play("reverse pass");
			//	Debug.Log("reverse pass");
				break;
			}
			timePassed = 0;
			}
			
			
		}
		
		
	
	}
	