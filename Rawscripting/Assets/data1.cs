using UnityEngine;
using System.Collections;

public class data1 : MonoBehaviour

	// Use this for initialization
	
	{
	  void Start () 

		{
			//Value type variable
			Vector3 pos = transform.position;
			pos = new Vector3(1, 3, 1);
			
			//Reference type variable
			Transform tran = transform;
			tran.position = new Vector3(1, 3, 1);
		}
	}