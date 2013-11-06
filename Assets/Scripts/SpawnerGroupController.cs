using UnityEngine;
using System.Collections;

public class SpawnerGroupController : MonoBehaviour {
	
	public float waveInterval = 5.0f;
	private float timePassed;
	private GameObject spawni;
	private static Sequences[] inUse;
	private static int amountInUse;
	
	private enum Sequences {onePass, zigzag, leftRow, rightRow, middleRow, reversePass}
	
	Sequences GetRandomEnum(){
	    System.Array A = System.Enum.GetValues(typeof(Sequences));
	    Sequences V = (Sequences)A.GetValue(UnityEngine.Random.Range(0,A.Length));
	    return V;
	}
	
	// Use this for initialization
	void Start () {
		timePassed = 10;
		spawni = this.gameObject;
		inUse = new Sequences[2];
	}
	
	// Update is called once per frame
	void Update () {
		
		timePassed += Time.deltaTime;
		
		//Debug.Log(timePassed);
		Sequences seq = GetRandomEnum();
		
		
		if(amountInUse > 1){
			inUse = new Sequences[2];
			amountInUse = 0;
			
		}else{
			inUse[amountInUse] = seq;
			//Debug.Log(amountInUse);
			amountInUse++;
		}
		bool foundFreeAnimation = false;
		while(!foundFreeAnimation){
			foundFreeAnimation = true;
			for(int i = 0; i < amountInUse;i++){
				if(seq.CompareTo(inUse[i]) == 0){
					foundFreeAnimation = false;		
					seq = GetRandomEnum();
					break;
					
				}
			}			
		}
		
		
		
		//Debug.Log(timePassed);
		if(!spawni.animation.isPlaying){
			
			switch(seq){
			case Sequences.onePass:
				
				spawni.animation.Play("one pass");
				//Debug.Log("one pass");
				break;
			
			case Sequences.zigzag:
				spawni.animation.Play("Zigzag");
				// Debug.Log("Zigzag");
				break;
			case Sequences.leftRow:
				spawni.animation.Play("Left row");
				//Debug.Log("Left row");
				break;
				
			case Sequences.rightRow:
				spawni.animation.Play("Right row");
				//Debug.Log("Right row");
				break;
				
			case Sequences.middleRow:
				spawni.animation.Play("Middle row");
				//Debug.Log("Middle row");
				break;
			
			
			case Sequences.reversePass:
				spawni.animation.Play("reverse pass");
				//Debug.Log("reverse pass");
				break;
			}
			timePassed = 0;
			}
			
			
		}
		
		
	
	}
	