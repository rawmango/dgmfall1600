using UnityEngine;
using System.Collections;

public class usingin : MonoBehaviour
{
	public Rigidbody Bullets;
	public Transform Tower;
	
	
	void Update ()
	{
		if(Input.GetKeyDown("b"))
			//(Input.GetKeyDown(KeyCode.LeftShift)//
		{
			Rigidbody BulletsInstance;
			BulletsInstance = Instantiate(Bullets, Tower.position, Tower.rotation) as Rigidbody;
			BulletsInstance.AddForce(Tower.forward * 7000);
				//{
					//Destroy (gameObject, 10.5f);
				//}
			}
		}
	}
