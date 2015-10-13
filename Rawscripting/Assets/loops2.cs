using UnityEngine;
using System.Collections;

public class loops2 : MonoBehaviour
	{
		void Start () 
		{ 
			string[] balls = new string[4];
			
			balls[0] = "First Ball";
			balls[1] = "Second Ball";
			balls[2] = "Third Ball";
			balls[3] = "Four Ball";
			
			foreach(string item in balls)
			{
				print (item);
			}
		}
	}




