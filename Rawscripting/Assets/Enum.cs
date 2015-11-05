using UnityEngine;
using System.Collections;

public class Enum : MonoBehaviour 
	{
		enum Direction{Orem=27, Lehi=13, Payson=7, Provo=19, };
	
	void Start () 
	{
		Direction myDirection = ReverseDirection (Direction.Orem);//(Direction.Payson);
	
		Debug.Log (myDirection);
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


		return (dir);
		
	}
	void Update ()
	{
		//Debug.Log ("my direction is" + Direction);
	}
}

