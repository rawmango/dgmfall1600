using UnityEngine;
using System.Collections;

public class borders : MonoBehaviour {
	public Transform terrain;
	Camera camera;
	
	void Start() {
		camera = GetComponent<Camera>();
	}
	
	void Update() {
		Vector3 screenPos = camera.WorldToScreenPoint(terrain.position);
		Debug.Log("terrain is " + screenPos.x + " pixels from the left");
	}
}