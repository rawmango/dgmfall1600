using UnityEngine;
using System.Collections;

public class bullets : MonoBehaviour {
	
	
	
	void  Update (){
		
		if(Input.GetKey("x")){
			transform.Rotate(0,-3,0);
		}
		
		if(Input.GetKey("v")){
			transform.Rotate(0,3,0);
		}
		
	}
}