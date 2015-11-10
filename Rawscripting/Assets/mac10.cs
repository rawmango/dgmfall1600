using UnityEngine;  
using System.Collections;  

public class Mac10 : MonoBehaviour  
{  
	//a Transform that is used to instantiate the bullet  
	public Transform muzzleTransform;  
	//a variable to store the Bullet game object loaded from the Resources folder  
	private GameObject bullet;  
	//A variable that serves as a handle to the newly instantiated bullet  
	private GameObject instantiatedBullet;  
	//This Quaternion defines the rotation of each instantiated bullet  
	private Quaternion bulletRotation = new Quaternion(0.7f,0,0,0.7f);  
	
	void Awake()  
	{  
		//load the 'Bullet' prefab from the resources folder  
		bullet = (GameObject)Resources.Load("Bullet");  
	}  
	
	// Update is called once per frame  
	void Update ()  
	{  
		//while the "Fire1" button is being held down  
		if(Input.GetButton("Fire1"))  
		{  
			//Start the DelayedShot method as a coroutine  
			StartCoroutine("DelayedShot",0.2f);  
		}  
	}  
	
	//A method that returns a IEnumerator so it can be yield  
	IEnumerator DelayedShot(float delay)  
	{  
		//wait for the time defined at the delay parameter  
		yield return new WaitForSeconds(delay);  
		//instantiate the bullet at the gun's muzzle  
		instantiatedBullet = (GameObject)Instantiate(bullet, muzzleTransform.position, muzzleTransform.rotation * bulletRotation);  
		//add velocity to the bullet  
		instantiatedBullet.rigidbody.velocity =  muzzleTransform.TransformDirection(Vector3.forward * 75 );  
		//Stop this coroutine  
		StopCoroutine("DelayedShot");  
	}  
}  