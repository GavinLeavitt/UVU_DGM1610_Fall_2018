using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Speed;
	public GameObject PC;

	public GameObject EnemyDeath;

	public GameObject ProjectileParticle;
	public GameObject HealthPickup;
	public GameObject AmmoPickup;
	public GameObject LifePickup;

	public int PointsForKill;

	public int TimeOut;

	// Use this for initialization
	void Start () {
		PC = GameObject.Find("PC");
		
		EnemyDeath = Resources.Load("Prefab/Death Particles") as GameObject;
		ProjectileParticle = Resources.Load("Prefab/Respawn Particles") as GameObject;
		HealthPickup = Resources.Load("Prefab/Health") as GameObject;
		AmmoPickup = Resources.Load("Prefab/Ammo") as GameObject;
		LifePickup = Resources.Load("Prefab/Life") as GameObject;

		if(PC.transform.localScale.x < 0)
			Speed = -Speed;

		Destroy(gameObject, TimeOut);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	// Destroy the projectile and the enemy when it enters the trigger area of an enemy
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			// Drop some loot at random. Loot is weighted: Ammo has highest chance, then Health, then no loot drop, then Lives.
			switch(Random.Range(0, 11)) {
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
					Instantiate(AmmoPickup, other.transform.position, other.transform.rotation);
					break;

				case 5:
				case 6:
				case 7:
				case 8:
					Instantiate(HealthPickup, other.transform.position, other.transform.rotation);
					break;

				case 9:
					Instantiate(LifePickup, other.transform.position, other.transform.rotation);
					break;
			}
			Destroy (other.gameObject);
			ScoreManager.AddPoints (PointsForKill);
			Destroy (gameObject);
		}

		Destroy (gameObject, 10);
	}

	// Destroy the projectile when it enters a collision box, other than those of the player and other projectiles
	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag != "Player" && other.gameObject.tag != "Projectile"){
			Instantiate (ProjectileParticle, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}
}
