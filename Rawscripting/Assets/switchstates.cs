using UnityEngine;
using System.Collections;

public class switchstates : MonoBehaviour 
{
	public int ciaintel = 5;
		
		
	void Greet()
	{
		switch (ciaintel) 
		{
		case 5:
			print ("$5000 nikon camera with lots of zoom lens");
			break;
		case 4:
			print ("deaddrop!");
			break;
		case 3:
			print ("hand gun with silencer and sniper rifle ");
			break;
		case 2:
			print ("fake passports");
			break;
		case 1:
			print (" secret goverment intel");
			break;
		default:
			print ("100k in cash in the hotel room.");
			break;

			{
				Debug.Log("case 2"; + print);
			}
		}
	}
}
