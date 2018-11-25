using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysHomework : MonoBehaviour {
	public string[] Inventory = new string[10];
	public int[] Stats = new int[5];
	public string[] NPCName = new string[6];
	public int[] BossHP = new int[6];
	public string[] PartyCharRace = new string[4];

	// Use this for initialization
	void Start () {
		// Initialize inventory array with random items
		for(int i = 0; i < Inventory.Length; i++){
			switch(Random.Range(0,5)) {
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
		// Stats array
		// HP
		Stats[0] = 100;
		// Level
		Stats[1] = 1;
		// Base stats. 2 = Attack, 3 = Defense, 4 = Speed
		Stats[2] = Random.Range(3, 5);
		Stats[3] = Random.Range(3, 5);
		Stats[4] = Random.Range(3, 5);
		// A list would be way better...? Or an enum if those worked

		// Randomize NPC name
		for (int i = 0; i < NPCName.Length; i++) {
			switch(Random.Range(0, 5)) {
				case 0:
					NPCName[i] = "G";
				break;

				case 1:
					NPCName[i] = "R";
				break;

				case 2:
					NPCName[i] = "U";
				break;

				case 3:
					NPCName[i] = "H";
				break;

				case 4:
					NPCName[i] = "F";
				break;
			}
		}
		// Print the name
		print("I now call to the stand the honorable citizen, " + NPCName[0] + NPCName[1] + NPCName[2] + NPCName[3] + NPCName[4] + "!");

		// Randomize HP of bosses throughout the game. The later the boss, the higher the multiplier of HP.
		for (int i = 0; i < BossHP.Length; i++) {
			BossHP[i] = Random.Range(50, 250)*(i+1);
		}

		// Randomize the race of each party member
		for (int i = 0; i < PartyCharRace.Length; i++) {
			switch(Random.Range(0, 6)) {
				case 0:
					PartyCharRace[i] = "An average human.";
				break;

				case 1:
					PartyCharRace[i] = "A stout dwarf.";
				break;

				case 2:
					PartyCharRace[i] = "An elegant elf.";
				break;

				case 3:
					PartyCharRace[i] = "An unassuming halfling.";
				break;

				case 4:
					PartyCharRace[i] = "A snivelling goblin.";
				break;

				case 5:
					PartyCharRace[i] = "Literally a rock with a face drawn on it.";
				break;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
