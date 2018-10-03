using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopQuiz : MonoBehaviour {
	/// Pop Quiz 10/3/2018

	// Declare three public integer variables
	public int Var0;
	public int Var1;
	private int Total;

	// This is the part I forgot. It actually uses the variables as the argument for the function.
	public void Calc(){
		Add(Var0, Var1);
	}

	// Function to add the two variables and print the sum
	public void Add(int One, int Two) {
		Total = One + Two;
		print(Total);
	}

	// Use this for initialization
	void Start () {
		Add(Var0, Var1);
	}
	
	// Update is called once per frame
	void Update () {

	}

}
