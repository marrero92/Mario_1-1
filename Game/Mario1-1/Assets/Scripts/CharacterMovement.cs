using UnityEngine;
using System.Collections;

public class CharacterMovement : CharacterBehavior {

    public float speed = 100f;
    public float runMult = 2f;

	// Use this for initialization
	void Start () { 
	
	}
	
	// Update is called once per frame
	void Update () {

        var right = inputState.GetButtonValue(inputButtons[0]);
        var left = inputState.GetButtonValue(inputButtons[1]);
        var run = inputState.GetButtonValue(inputButtons[2]);

        //conditional that make sure right or left are being inputed
        if(right || left)
        {
            var tempSpeed = speed;

           if(run && runMult > 0)
            {
                tempSpeed *= runMult;
            }

            var velX = tempSpeed * (float)inputState.direction;

            rb.velocity = new Vector2(velX, rb.velocity.y);

        }

    }

}
