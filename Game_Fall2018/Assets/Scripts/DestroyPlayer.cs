using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour {


	public LevelManager LevelManager;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "PC"){
			if (other.GetComponent<Renderer> ().enabled)
			LevelManager.RespawnPlayer();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
