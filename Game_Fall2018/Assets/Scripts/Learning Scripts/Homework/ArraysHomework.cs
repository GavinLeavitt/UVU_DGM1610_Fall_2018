using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysHomework : MonoBehaviour {
	public string[] Inventory = new string[10];

	// Use this for initialization
	void Start () {
		for(int i = 0; i < 10; i++){
			switch(Random.Range(0,4)) {
				case 0:
					Inventory[i] = "Gold piece";
				break;

				case 1:
					Inventory[i] = "Healing potion";
				break;

				case 2:
					Inventory[i] = "Rusty shortsword";
				break;

				case 3:
					Inventory[i] = "Splintered shield";
				break;

				case 4:
					Inventory[i] = "Length of rope";
				break;

				default:
					Inventory[i] = "A dusty, empty pouch";
				break;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
