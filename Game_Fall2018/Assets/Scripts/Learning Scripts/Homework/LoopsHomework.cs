using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsHomework : MonoBehaviour {

	private int OgreSize;
	public GameObject Enemy;
	private int TreeHeight;
	private int YearsToGrow;
	private int Forecast;

	// Use this for initialization
	void Start () {
		for (int i=0; i <= 15; i++) {
			print(i + " inventory spaces available.");
		}

		for (int i=99; i > 0; i--) {
			print(i + " bottles of beer on the wall...");
		}

		for (int i=0; i < 5; i++) {
			int OgreSize = Random.Range(2, 12);
			print("Ogre number " + (i+1) + " is " + OgreSize + " feet tall!");
			if(OgreSize>6) {
				print(" Maybe you should run away?!");
			} else if (OgreSize<4) {
				print(" Awww... It's almost cute!");
			}
		}

		// I don't know if this next one actually works, but what I'm getting at is that it spawns 3 enemies, each in a random X position.
		while(GameObject.FindGameObjectsWithTag("Enemy").Length < 3) {
			Instantiate(Enemy, new Vector3(Random.Range(-12.0f, 1.5f), 0, 0), Quaternion.identity);
		}

		// You could also replace the "3" in the condition for the While loop with a random integer between 1 and 6 or so, so a random number of enemies would spawn at the start.
		// You could probably combine the two above loops to give each spawned enemy a random size as well.

		TreeHeight = 1;
		YearsToGrow = 0;
		while(TreeHeight < 12) {
			TreeHeight += (Random.Range(1, 4));
			YearsToGrow ++;
		}

		print("It took " + YearsToGrow + " years to grow!");
		// Something like this could be used in a long-form simulation style game??? Maybe? You'd have to calculate it all beforehand and then have an adaptive animation 
		//showing the tree's growth progress... But you could influence the "random" growth of the tree by what fertilizer, land, weather, etc. was in play.

		Forecast = 0;
		while(Forecast < 7) {
			switch(Random.Range(0,3)) {
				case 0:
					print("Clear skies and balmy weather.");
				break;

				case 1:
					print("A 75% chance for some light precipitation.");
				break;

				case 2:
					print("A violent, sulfuric hellstorm's blowing in from the north. Might want to wear a light jacket.");
				break;
			}
			Forecast++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
