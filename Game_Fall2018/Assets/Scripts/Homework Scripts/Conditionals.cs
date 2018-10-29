using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {

	public string Weather;

	// Use this for initialization
	void Start () {
		if(Weather == "Raining")
			print("The old man is snoring...");
		else if (Weather == "Snowing")
			print("The weather outside is frightful; here's a misogynistic song about it.");
		else if(Weather == "Sunny")
			print("The merciless star pressed down on the lowly planet-dwellers...");
		else if(Weather == "Cloudy")
			print("The great shadows stretched across the valley, obscuring all in their wake.");
		else
			print("I guess it's " + Weather + "...?");
	}
}
