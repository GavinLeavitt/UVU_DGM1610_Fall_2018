using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsHomework : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int i=0; i <= 15; i++) {
			print(i + " inventory spaces available.");
		}

		for (int i=99; i > 0; i--) {
			print(i + " bottles of beer on the wall...");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
