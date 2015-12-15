using UnityEngine;
using System.Collections;

public class AutoD : MonoBehaviour {
		void OnTriggerEnter(Collider other) {
			if (other.CompareTag("GI"))
				Destroy(other.gameObject);

		}
	}
//	GameObject delay= 20.0f; //This implies a delay of 2 seconds.
	
	//  WaitAndDestroy (){
	//	yield return new WaitForSeconds(delay);
	//	Destroy (gameObject);
	
//}