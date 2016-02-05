using UnityEngine;
using System.Collections;

public class Jump : CharacterBehavior {

    public float jumpSpeed = 200f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	protected virtual void Update () {

        var canJump = inputState.GetButtonValue(inputButtons[0]);
        var holdtime = inputState.GetButtonHoldTime(inputButtons[0]);
       if(collisionState.standing)
        {
            if (canJump && holdtime < .1f)
            {
                OnJump();
            }
        }
	
	}

    protected virtual void OnJump()
    {

        var vel = rb.velocity;
        rb.velocity = new Vector2(vel.x, jumpSpeed);

    }
}
