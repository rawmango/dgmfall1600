using UnityEngine;
using System.Collections;

public class switchstates : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	{
		public int iceintel = 5;
		
		
		void Greet()
		{
			switch (iceintel)
			{
			case 5:
				print (" hey there! Let me teach you thing or two!");
				break;
			case 4:
				print ("deaddrop!");
				break;
			case 3:
				print ("?");
				break;
			case 2:
				print ("Grog SMASH!");
				break;
			case 1:
				print ("Ulg, glib, Pblblblblb");
				break;
			default:
				print ("Incorrect intelligence level.");
				break;
			}
		}
	}



	// Update is called once per frame
	void Update () {
	
	}
}
