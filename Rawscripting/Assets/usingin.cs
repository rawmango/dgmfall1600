using UnityEngine;
using System.Collections;

public class usingin : MonoBehaviour
{
	public Rigidbody Bullets;
	public Transform BEnd;
	
	
	void Update ()
	{
		if(Input.GetButtonDown("Jump"))
			//(Input.GetKeyDown(KeyCode.LeftShift)//
		{
			Rigidbody BulletsInstance;
			BulletsInstance = Instantiate(Bullets, BEnd.position, BEnd.rotation) as Rigidbody;
			BulletsInstance.AddForce(BEnd.right * 1000);
			//InstanceBullets= Instantiate(Bullets, transform.position, shootPosition.rotation);
			//instanceBullet.rigidbody.AddForce(shootPosition.right * shootForce);
			
		}

			
		}
		//{
		//Destroy (gameObject, 10.5f);
				//}
			}
		
	



