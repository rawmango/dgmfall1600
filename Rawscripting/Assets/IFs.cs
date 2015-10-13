using UnityEngine;
using System.Collections;

public class IFs : MonoBehaviour
{
<<<<<<< HEAD
	float coffeeTemperature = 85.0f;
	float hotLimitTemperature = 70.0f;
	float coldLimitTemperature = 40.0f;

void Update ()

=======
	public float yougetburned = 100.0f;
	public float tshirt = 85.0f;
	public float wintercoat = 40.0f;
	
         void Update ()
>>>>>>> IFs
	{
		if(Input.GetKeyDown(KeyCode.Space))
			HeatTest();
		
		yougetburned -= Time.deltaTime *5;
	}
	
	
		void HeatTest ()
	{
		// If the temperature is greater than the hottest temperature...
		if(yougetburned > tshirt)
		{
			// ... do this.
			print("it's too hot outside, you will get burned.");
		}
		// If it isn't, but the temperature is less than the coldest temperature...
		else if(yougetburned < wintercoat)
		{
			// ... do this.
			print("you need a winter coat");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("you can wear a t-shirt");
		}
	}
}
