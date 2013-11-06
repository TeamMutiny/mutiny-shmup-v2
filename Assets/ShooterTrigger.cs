using UnityEngine;
using System.Collections;

public class ShooterTrigger : MonoBehaviour {
	
	void broadcastShoot() {
		gameObject.BroadcastMessage("shootAtPlayer",null,SendMessageOptions.DontRequireReceiver);
	}
}
