using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int HydraHeads;
	public string Name;

	// Use this for initialization
	void Start () {

		if(HydraHeads>1 || HydraHeads==0){
			print(HydraHeads + " heads of the hydra are left.");
		} else if(HydraHeads==1) {
			print("Only " + HydraHeads + " head of the hydra is left!" );
		}

		switch(HydraHeads){
			case 0:
				print("The beast is slain.");
			break;

			case 1:
				print("There is nary a foe more deadly than a cornered beast.");
			break;

			case 2:
				print("Two heads are better than one, but significantly less intimidating than three.");
			break;

			case 3:
				print("What remains is a triumvirate of teeth and terror.");
			break;

			case 4:
				print("One gnashing maw for each of its victims' limbs.");
			break;

			case 5:
				print("A cacophonic quintet of screams and spittle heralds the battle's beginning!");
			break;
			
			default:
				print("What eldritch monstrosity is this-- " + HydraHeads + " heads?!");
			break;
		}

		switch(Name){
			case "Dracula":
				print(Name + ": The death is all that matters.");
			break;

			case "Alucard":
				print(Name + ": I grieve with you.");
			break;

			case "Trevor":
				print(Name + ": I could use a drink...");
			break;

			case "Sypha":
				print(Name + ": I serve no demon and do no evil!");
			break;

			default:
				print(Name + ": What a horrible night for a curse...");
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
