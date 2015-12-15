using UnityEngine;
using System.Collections;

public class AutoD : MonoBehaviour {
	float life;
	private float destroyTime;
	
	void  Start (){
		destroyTime = Time.time + life;
	}
	
	void  Update (){
		if(Time.time > destroyTime){
			Destroy(gameObject);
		}
		if(Time.time > destroyTime - particleEmitter.maxEnergy){
			particleEmitter.emit = false;
		}
		
	}

}
