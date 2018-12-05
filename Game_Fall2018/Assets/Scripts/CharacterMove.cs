using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public int MoveSpeed;
	public float JumpHeight;
	private bool DoubleJump;

	private int RightInput;
	private int LeftInput;
	private int MoveAxis;

	// Player grounded variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	//Non-Stick Player
	private float MoveVelocity;

	public Animator Animator;

	// Use this for initialization
	void Start () {
		Animator.SetBool("IsWalking", false);
		Animator.SetBool("IsJumping", false);
		Animator.SetBool("IsFalling", false);
	}
	
	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}

	// Update is called once per frame
	void Update () {
		
		// This code makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
		}

		// Double jump code
		if(Grounded) {
			DoubleJump = false;
		}

		if(Input.GetKeyDown (KeyCode.Space)&& !DoubleJump && !Grounded){
			Jump();
			DoubleJump = true;
		}

		//Non-Stick Player
		MoveVelocity = 0f;

		// This code makes the character move from side to side using the A and D keys
		if(Input.GetKey (KeyCode.D)){
			//GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			MoveVelocity = MoveSpeed;
			Animator.SetBool("IsWalking", true);
		} else if (Input.GetKeyUp(KeyCode.D)){
			Animator.SetBool("IsWalking", false);
		}

		if(Input.GetKey (KeyCode.A)){
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			MoveVelocity = -MoveSpeed;
			Animator.SetBool("IsWalking", true);
		} else if (Input.GetKeyUp(KeyCode.A)){
			Animator.SetBool("IsWalking", false);
		}

		if (!Grounded || GetComponent<Rigidbody2D>().velocity.y != 0) {
			if (GetComponent<Rigidbody2D>().velocity.y < 0) {
				Animator.SetBool("IsFalling", true);
			} else {
				Animator.SetBool("IsFalling", false);
			}
			Animator.SetBool("IsJumping", true);
		} else {
			Animator.SetBool("IsFalling", false);
			Animator.SetBool("IsJumping", false);
		}

		GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);

		// Flip player sprite
		if (GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(1f, 1f, 1f);
		else if (GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-1f, 1f, 1f);
	}

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
