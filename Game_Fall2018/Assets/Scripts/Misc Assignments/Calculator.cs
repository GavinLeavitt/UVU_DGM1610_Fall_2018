using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour {

	// Declare variables
	public int Var0;
	public int Var1;
	private int Total;

	// Various functions
	public void Add(int One, int Two) {
		Total = One+Two;
	}

	public void Subtract(int One, int Two) {
		Total = One-Two;
	}

	public void Multiply(int One, int Two) {
		Total = One*Two;
	}

	public void Divide(int One, int Two) {
		Total = One/Two;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Events for calling the function
		if(Input.GetKeyDown (KeyCode.A)) {
			Add(Var0,Var1);
			print(Total);
		}

		if(Input.GetKeyDown (KeyCode.S)) {
			Subtract(Var0,Var1);
			print(Total);
		}

		if(Input.GetKeyDown (KeyCode.M)) {
			Multiply(Var0,Var1);
			print(Total);
		}

		if(Input.GetKeyDown (KeyCode.D)) {
			Divide(Var0,Var1);
			print(Total);
		}
	}
}
