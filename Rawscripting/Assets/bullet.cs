using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
	
	
	
	void  Update (){
		
		if(Input.GetKey("z")){
			transform.Rotate(0,-2,0);
		}
		
		if(Input.GetKey("c")){
			transform.Rotate(0,2,0);
		}
		
	}
}