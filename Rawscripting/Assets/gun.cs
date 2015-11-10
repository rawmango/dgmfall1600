using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour {

	// Use this for initialization
	void Start () 


		var Bullet : Transform;
		var Spawn : Transform;
		function Update ()
		{ if(Input.GetButtonDown("Fire1"­­)) { Shot(); }
		}
		function Shot()
		{ var pel = Instantiate(Bullet, Spawn.position, Spawn.rotation); pel.rigidbody.AddForce(transfo­rm.forwar­d * 8000);
			audio.Play();
		}
	}
	}
}

var bullet : GameObject;
var spawnPoint : Transform;

function Update () {
	if(Input.GetKeyDown("mouse0") {
		var nBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
		nBullate.rigidbody.velocity = spawnPoint.TransformDirection(Vector3(0,0,100));
	}