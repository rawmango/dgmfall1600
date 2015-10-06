using UnityEngine;
using System.Collections;

public class loops : MonoBehaviour {

			int shirtsonthefloor = 9;
			
			void Start ()
			{
				while(shirtsonthefloor > 0)
				{
					Debug.Log ("I've washed one of the shirts!");
					shirtsonthefloor--;
				}
			}
		}	
