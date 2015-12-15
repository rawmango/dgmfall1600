﻿using UnityEngine;
using System.Collections;

public class SCam : MonoBehaviour {

	float cameraTiltMultiplier = 1.0f;
	private Vector3 lastPosition;
	private float forwardSpeed;
	private float cameraTilt;
	private float verticalAim;
	private Vector3 localPosition;
	private Vector3 positionOffset;
	//External scripts.

	//Soldier parts.
	private Transform spine2;
	
	void  Start (){
		cameraTilt = 0.0f;
		localPosition = transform.localPosition;
		positionOffset = Vector3.zero;

		spine2 = transform.root.Find("smoothWorldPosition/soldierSkeleton/Bip01/Bip01 Pelvis/Bip01 Spine/Bip01 Spine1/Bip01 Spine2");
	}
	
	void  Update (){
		float health = 100;

		}
		//Camera tilt.
		//float cameraTiltTarget;
		//cameraTiltTarget = Input.GetAxis("Mouse X");
		//Vector3 velocity = transform.root.position - lastPosition;
		//lastPosition =transform.root.position;
		///forwardSpeed =transform.InverseTransformDirection(velocity).z;
		///cameraTiltTarget *= -forwardSpeed * 60.0f * cameraTiltMultiplier ;
		//cameraTiltTarget = Mathf.Clamp(cameraTiltTarget,-30,30);
		//cameraTilt = Mathf.Lerp(cameraTilt, cameraTiltTarget, Time.deltaTime * 3.0f);
		//if(health > 0){
		//transform.localRotation.eulerAngles.z = cameraTilt;
		}
		//Vertical aim.
		//verticalAim -= Input.GetAxis("Mouse Y") * Time.deltaTime * 100.0f;
		//verticalAim = Mathf.Clamp(verticalAim,-40,50);
		//float crouchCameraYOffset = 0.0f; //Camera crouch;
		
		//Local position.
		//if(verticalAim > 0){
			//positionOffset.y = verticalAim * 0.03f;
		//}
		//else{
			//positionOffset.y = verticalAim * 0.02f;
		//}
		
		

		//Death Camera.
		//if(health <= 0){
		//Vector3 spineRelativePos = spine2.position - transform.position;
			//Quaternion lookSpineRotation = Quaternion.LookRotation(spineRelativePos);
			//transform.rotation = Quaternion.Slerp(transform.rotation, lookSpineRotation,Time.deltaTime*3.0f);
			//transform.localPosition = Vector3.Lerp(transform.localPosition,Vector3(2,3,0),Time.deltaTime*3.0f);
	//	}
//	}
	
//}
//}