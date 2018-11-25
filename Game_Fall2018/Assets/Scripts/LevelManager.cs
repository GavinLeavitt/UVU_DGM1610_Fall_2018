﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	public Rigidbody2D Player;

	public GameObject CurrentPlayer;

	// Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	// Respawn Delay
	public float RespawnDelay;

	// Point Penalty on Death
	public int PointPenaltyOnDeath;

	// Store Gravity Value
	private float GravityStore;


	// Use this for initialization
	void Start () {
		// Player = FindObjectOfType<Rigidbody2D> ();
		DeathParticle = Resources.Load("Prefab/Death Particles") as GameObject;
		RespawnParticle = Resources.Load("Prefab/Respawn Particles") as GameObject;
	}

	public void RespawnPlayer(){
		StartCoroutine("RespawnPlayerCo");
	}

	public void GameOver(){
		//Hide Player
		CurrentPlayer.SetActive(false);
		Player.GetComponent<Renderer> ().enabled = false;
	}

	public IEnumerator RespawnPlayerCo(){
		//Generate Death Particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//Hide Player
		// player.enabled = false;
		CurrentPlayer.SetActive(false);
		Player.GetComponent<Renderer> ().enabled = false;
		// Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D> ().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		// Point Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		// Debug Message
		Debug.Log ("Player Respawn");
		// Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);
		// Gravity Restore
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		// Match Player's transform position
		Player.transform.position = CurrentCheckPoint.transform.position;
		//Show Player
		CurrentPlayer.SetActive(true);
		// player.enabled = true;
		Player.GetComponent<Renderer> ().enabled = true;
		// Spawn Player
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
