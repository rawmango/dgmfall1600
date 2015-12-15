using UnityEngine;
using System.Collections;

public class AutoD : MonoBehaviour {
		void OnTriggerEnter(Collider other) {
			if (other.CompareTag("soldier"))
				Destroy(other.gameObject);
		float delay= 20.0f; }
}//This implies a delay of 2 seconds.
	
	//  WaitAndDestroy (){
	//	yield return new WaitForSeconds(delay);
	//	Destroy (gameObject);
	
//}