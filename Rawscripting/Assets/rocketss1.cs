using UnityEngine;
using System.Collections;

public class rocketss1 : MonoBehaviour 
	// Update is called once per frame
	void Update () 
{
	//if the AutoDestruct() method isn't already being invoked
	if(!IsInvoking("AutoDestruct"))
	{
		//schedule the execution of the AutoDestruct() method to happen in the next 3 seconds
		Invoke("AutoDestruct",3);
	}
	
}

//destroys the game object
void AutoDestruct()
{
	Destroy(gameObject);
}
