using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalsHomework : MonoBehaviour {
	public int ChargeLevel;
	public void ChargeShot() {
		if (ChargeLevel < 300) {
			ChargeLevel ++;
		}
	}
	public void NotCharging() {
		if (ChargeLevel > 0) {
			ChargeLevel --;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Check to see if holding the charge weapon key
		if (Input.GetKey(KeyCode.C)) {
			ChargeShot();
		// Check to see when the charge key is released, print corresponding beam power
		// (You could also use the ChargeLevel value to calculate damage, increase radius of glowy gun charge effects, etc.)
		} else if (Input.GetKeyUp(KeyCode.C)) {
			if (ChargeLevel <= 100) {
				print("Lemons!");
			} else if (ChargeLevel > 100 && ChargeLevel <=200) {
				print("Green blast!");
			} else if (ChargeLevel > 200 && ChargeLevel < 300) {
				print("Blue blast!!!");
			} else if (ChargeLevel == 300) {
				print("Crazy wavy purple blast!!!!! :O");
			}
		} else {
			NotCharging();
		}
	}
}
