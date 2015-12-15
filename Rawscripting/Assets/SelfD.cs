using UnityEngine;
using System.Collections;

public class SelfD : MonoBehaviour {
	float life;
	private float destroyTime;
	
	void  Start (){
		destroyTime = Time.time + life;
	}
	
	void  Update (){
		if(Time.time > destroyTime){
			Destroy(gameObject);
		}
	}
}