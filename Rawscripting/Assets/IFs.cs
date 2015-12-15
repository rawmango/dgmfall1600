using UnityEngine;
using System.Collections;

public class IFs : MonoBehaviour
{
		
	public float gettingoverrun = 100.0f;
	public float draw = 85.0f;
	public float winning = 40.0f;


	void Update ()
		{
		if(Input.GetKeyDown(KeyCode.Space))
			 HeatTest();
		
		gettingoverrun -= Time.deltaTime *5;
	    }

		void HeatTest ()
	{
		// If the temperature is greater than the hottest temperature...
		if(gettingoverrun> draw)
		{
			// ... do this.
			print("Getting Overrun by Ememy Soldiers.");
		}
		// If it isn't, but the temperature is less than the coldest temperature...
		else if(gettingoverrun < winning)
		{
			// ... do this.
			print("you have defeat the ememy and our winning");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("you can wear a t-shirt");
		}
	}
}