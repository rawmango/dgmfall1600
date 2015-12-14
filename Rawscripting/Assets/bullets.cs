using UnityEngine;
using System.Collections;

public class bullets : MonoBehaviour {

	public Transform target;
	public Transform gun;
	public float turretDegreesPerSecond = 5.0f;
	public float gunDegreesPerSecond  = 5.0f;
	
	public float maxGunAngle = 45.0f;
	
	private Quaternion qTurret;
	private Quaternion qGun;
	private Quaternion qGunStart;
	private Transform trans ;
	
	void Start() {
		trans = transform;    
		qGunStart = gun.transform.localRotation;
	}
	
	void Update () {
		Debug.DrawRay(gun.position, gun.forward * 5.1f);
		float distanceToPlane = Vector3.Dot(trans.up, target.position - trans.position);
		Vector3 planePoint = target.position - trans.up * distanceToPlane;
		
		qTurret = Quaternion.LookRotation(planePoint - trans.position, transform.up);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, qTurret, turretDegreesPerSecond  * Time.deltaTime);
		
		Vector3 v3 = new Vector3(0.9f, distanceToPlane, (planePoint - transform.position).magnitude);
		qGun = Quaternion.LookRotation(v3);
		
		if (Quaternion.Angle(qGunStart, qGun) <= maxGunAngle)
			gun.localRotation = Quaternion.RotateTowards(gun.localRotation, qGun, gunDegreesPerSecond * Time.deltaTime);
		else
			Debug.Log("Target beyond gun range");
	}
}