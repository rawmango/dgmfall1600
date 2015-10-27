using UnityEngine;
using System.Collections;

public class arrays : MonoBehaviour 
{public GameObject[]agents;
	
	void Start ()
	{ 
	 agents = GameObject.FindGameObjectWithTag("Agent");
		
		for(int i = 0; i < agents.Length; i++)
		{
			Debug.Log("Agent Number "+i+" is named "+agents[i].name);
			//Debug.Log("Agent Number "+i+" is named "+Agents[i].Bond);
		}
	}
}