using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {

	public ScoreManager ScoreManager;
	public int EnemyPower;

	// Use this for initialization
	void Start () {
		ScoreManager = FindObjectOfType <ScoreManager>();	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "PC"){
			ScoreManager.AddHealth(-EnemyPower);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
