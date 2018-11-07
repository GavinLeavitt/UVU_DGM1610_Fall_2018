using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysReview : MonoBehaviour {
	public string[] Pets = new string[5];

	// Use this for initialization
	void Start () {
		for(int i = 0; i < Pets.Length; i++){
			Pets[i] = "My old dog, Mr. Dog " + i;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
