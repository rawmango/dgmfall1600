using UnityEngine;
using System.Collections;

public class scope : MonoBehaviour 
	
{
	public int x = 7;
	
	
	private int y = 3;
	private int z  = 19;
	
	
	private AnotherClass myOtherClass;


	void Start () 
	{
		x = 29;
		
		myOtherClass = new AnotherClass ();
		myOtherClass.agentMachine (x, myOtherClass.sunglasses ); 
		//myOtherClass = new AnotherClass ();
		//myOtherClass.agentMachine (myOtherClass.earpiece ); 

	}
	
	void Example (int money, int maps)
	{
		int answer;
		answer = money * maps * x;
		Debug.Log(answer);
	}
	void Update ()
	{
		Debug.Log("x is set to: " + x);
	}
}