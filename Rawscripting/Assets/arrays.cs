using UnityEngine;
using System.Collections;

public class arrays : MonoBehaviour 
{
	public GameObject[] Agents;
	
	void Start ()
	{
		Agents = GameObject.FindGameObjectsWithTag("Agent");
		
		for(int i = 1; i < Agents.Length; i++)
		{
			Debug.Log("Agent Number "+i+" is named "+Agents[i].James);
			Debug.Log("Agent Number "+i+" is named "+Agents[i].Bond);
		}
	}
}