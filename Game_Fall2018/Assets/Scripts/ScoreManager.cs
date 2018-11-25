using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	
	public static int Score;
	public static int MaxHealth;
	public static int Health;
	public static int Ammo;
	public static int Lives;

	Text ScoreText;
	public LevelManager LevelManager;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
		ScoreText = GetComponent<Text>();

		Score = 0;
		MaxHealth = 10;
		Health = MaxHealth;
		Ammo = 50;
		Lives = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (Score < 0){
			Score = 0;
		}

		if (Health > MaxHealth) {
			Health = MaxHealth;
		}
		
		if (Health <= 0){
			Health = MaxHealth;
			AddLives(-1);
			if (Lives > 0) {
				LevelManager.RespawnPlayer();
			} else {
				LevelManager.GameOver();
				print("GAME OVER");
			}
		}
		ScoreText.text = "Score: " + Score + "\nHealth: " + Health + "\nAmmo: " + Ammo + "\nLives: " + Lives;
	}

	public static void AddPoints (int PointsToAdd) {
		Score += PointsToAdd;
	}
	public static void AddHealth (int HealthToAdd) {
		Health += HealthToAdd;
	}
	public static void AddAmmo (int AmmoToAdd) {
		Ammo += AmmoToAdd;
	}
	public static void AddLives (int LivesToAdd) {
		Lives += LivesToAdd;
	}

}
