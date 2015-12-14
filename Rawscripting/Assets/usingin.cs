using UnityEngine;
using System.Collections;

public class usingin : MonoBehaviour
{
	public Rigidbody Bullets;
	public Transform Tower;
	
	
	void Update ()
	{
		if(Input.GetKeyDown("b"))
		{
			Rigidbody BulletsInstance;
			BulletsInstance = Instantiate(Bullets, Tower.position, Tower.rotation) as Rigidbody;
			BulletsInstance.AddForce(Tower.forward * 5000);
				//{
					//Destroy (gameObject, 10.5f);
				//}
			}
		}
	}
