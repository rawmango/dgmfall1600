using UnityEngine;
using System.Collections;

public class bulletss : MonoBehaviour {

	void  Update (){
		
		if(Input.GetKey("x")){
			transform.Rotate(0,0,-1);
		}
		
		if(Input.GetKey("v")){
			transform.Rotate(0,0,1);
		}
		
	}
}