﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	// Shoot variables
	public Transform FirePoint;
	public GameObject Projectile;

	// Use this for initialization
	void Start () {
		Projectile = Resources.Load("Prefab/Projectile") as GameObject;	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl)) {
			if (ScoreManager.Ammo > 0) {
				Instantiate(Projectile, FirePoint.position, FirePoint.rotation);
				ScoreManager.Ammo --;
			}
		}
			

	}
}