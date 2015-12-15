using UnityEngine;
using System.Collections;

public class Blow : MonoBehaviour {
	void  OnCollisionEnter ( Collision collision  ){
		// Instantiate explosion at the impact point and rotate the explosion
		// so that the y-axis faces along the surface normal
		ContactPoint contact = collision.contacts[0];
	 rotation= Quaternion.FromToRotation(Vector3.up, contact.normal);
		
		if (collision.gameObject.tag =="Enemy"){
			// And kill our selves
			Kill ();
		}
	}
	
	void  Kill (){
		
		
		// Destroy the projectile
		Destroy(gameObject);
	}
}
	
