﻿using UnityEngine;
using System.Collections;

public class Enum : MonoBehaviour 
	{
		enum Direction{Orem=27, Lehi=13, Payson=7, Provo=19, };void Start () 
		{
			Direction myDirection;
			
			myDirection = Direction.Orem;
		}
		
		Direction ReverseDirection (Direction dir)
		{
		if (dir == Direction.Orem)
			dir = Direction.Lehi;
		else if (dir == Direction.Lehi)
			dir = Direction.Orem;
		else if (dir == Direction.Payson)
			dir = Direction.Provo;
		else if (dir == Direction.Provo)
			dir = Direction.Payson;

		//return dir

	}
	
	// Update is called once per frame
	void Update () {

			Debug.Log("Direction" );
			
	 }
}
