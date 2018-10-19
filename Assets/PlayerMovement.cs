using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public string JumpButton = "Jump1";
    public string CrouchButton = "Crouch1";
    public string HorizontalButton = "Horizontal1";

    public CharacterController2D controller;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	
	// Update is called once per frame
	void Update () {

		horizontalMove = Input.GetAxisRaw(HorizontalButton) * runSpeed;

		if (Input.GetButtonDown(JumpButton))
		{
			jump = true;
		}

		if (Input.GetButtonDown(CrouchButton))
		{          
			crouch = true;
        } else if (Input.GetButtonUp(CrouchButton))
		{
			crouch = false;
		}

	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}
