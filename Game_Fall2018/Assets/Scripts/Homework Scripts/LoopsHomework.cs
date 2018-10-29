using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsHomework : MonoBehaviour {

	private int OgreSize;

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


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
