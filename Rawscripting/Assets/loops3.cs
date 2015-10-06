using UnityEngine;
using System.Collections;

public class loops3 : MonoBehaviour 
	{
		int numfriends = 7;
		
		
		void Start ()
		{
			for(int i = 0; i < numfriends; i++)
			{
				Debug.Log("Creating friends number: " + i);
			}
		}
	}


