using UnityEngine;
using System.Collections;

public class Blow : MonoBehaviour {
	function OnCollisionEnter (collision : Collision) {
		// Instantiate explosion at the impact point and rotate the explosion
		// so that the y-axis faces along the surface normal
		var contact : ContactPoint = collision.contacts[0];
		var rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
		
		if (collision.gameObject.tag =="Enemy"){
			// And kill our selves
			Kill ();
		}
	}
	
	function Kill () {
		
		
		// Destroy the projectile
		Destroy(gameObject);
	}
	
	
	script RequireComponent (Rigidbody)
