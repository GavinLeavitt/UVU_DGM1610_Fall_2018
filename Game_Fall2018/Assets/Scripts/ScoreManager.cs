using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {
	
	public static int Score;

	public int WinScore;
	public Text WinText;
	public Text LoseText;

	public static int MaxHealth;
	public static int Health;
	public static int Ammo;
	public static int Lives;

	Text ScoreText;
	public LevelManager LevelManager;

	void Awake(){
		Time.timeScale = 1;
	}

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
		ScoreText = GetComponent<Text>();

		Score = 0;
		MaxHealth = 5;
		Health = MaxHealth;
		Ammo = 5;
		Lives = 3;

		ScoreText = GetComponent<Text>();
		WinText.GetComponent<Text>().enabled = false;
		LoseText.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Score < 0){
			Score = 0;
		}

		if (Health > MaxHealth) {
			Health = MaxHealth;
		}
		
		// If the player win display win text
		if(Score >= WinScore){
			print("Win Score Reached = " + Score);
			WinText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}

		// Subtract lives when health reaches 0
		if (Health <= 0){
			Health = MaxHealth;
			AddLives(-1);
			if (Lives > 0) {
				LevelManager.RespawnPlayer();
			} else {
				LevelManager.GameOver();
				LoseText.GetComponent<Text>().enabled = true;
				print("GAME OVER");
				Time.timeScale = 0;
			}
		}

		// If player hits the Escape key return to start menu
		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
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
