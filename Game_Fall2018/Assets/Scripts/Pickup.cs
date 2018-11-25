using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

	public int ValueToAdd;
	public string PickupType;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
			return;
		
		switch(PickupType) {
			case "Coin":
				ScoreManager.AddPoints(ValueToAdd);
			break;

			case "Health":
				ScoreManager.AddHealth(ValueToAdd);
			break;

			case "Ammo":
				ScoreManager.AddAmmo(ValueToAdd);
			break;

			case "Life":
				ScoreManager.AddLives(ValueToAdd);
			break;
		}

		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
