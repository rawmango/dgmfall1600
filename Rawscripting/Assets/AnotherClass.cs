using UnityEngine;
using System.Collections;

public class AnotherClass : MonoBehaviour 
{
	
	public int sunglasses;
	public int earpiece;
	
	
	private int gun;
	private int intel;

	
	public void agentMachine (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("agent total: " + answer);
	}
	
	
	private void spySort (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("spy total: " + answer);
	}
}