﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {
	public int[] Eggs = new int[12];
	public string[] Jedi = new string[5];

	// Use this for initialization
	void Start () {
		
		Eggs[0] = 1;
		Eggs[1] = 2;
		Eggs[2] = 3;
		Eggs[3] = 4;
		Eggs[4] = 5;
		Eggs[5] = 6;
		Eggs[6] = 7;
		Eggs[7] = 8;
		Eggs[8] = 9;
		Eggs[9] = 10;
		Eggs[10] = 11;
		Eggs[11] = 12;

		print(Eggs[8]);

		Jedi[0] = "Obi-Wan Kenobi";
		Jedi[1] = "Kitt Fisto";
		Jedi[2] = "Ki-Adi-Mundi";
		Jedi[3] = "Mace Windu";
		Jedi[4] = "Yoda";

		foreach(string item in Jedi){
			print("Jedi Master " + item);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
