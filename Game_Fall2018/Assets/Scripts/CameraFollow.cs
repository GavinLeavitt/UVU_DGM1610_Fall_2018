﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public CharacterMove PC;

	public bool IsFollowing;

	// Camera position offset
	public float XOffset;
	public float YOffset;

	// Use this for initialization
	void Start () {
		PC = FindObjectOfType<CharacterMove>();

		IsFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(IsFollowing){
			transform.position = new Vector3(PC.transform.position.x + XOffset, PC.transform.position.y + YOffset, transform.position.z);
		}
	}
}
