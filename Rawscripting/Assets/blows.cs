using UnityEngine;
using System.Collections;

public class blows : MonoBehaviour {

	void  OnCollisionEnter ( Collision collision  ){ 

		if(collision.gameObject.name==("Bullets(Clone)")) 
			
		{ 
			
			// Instantiate explosion at the impact point and rotate the explosion 
			// so that the y-axis faces along the surface normal 
			
			
			ContactPoint contact = collision.contacts[0]; 
		Quaternion rotation= Quaternion.FromToRotation(Vector3.up, contact.normal); 
			
			// And kill our selves 
			Kill (); 
		} 
		
	}
	
	void  Kill (){ 
		
		
		// Destroy the projectile 
		Destroy(gameObject); 
	}
}