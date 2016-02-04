using UnityEngine;
using System.Collections;
//                          Changed our behavior
public class FaceDirection : CharacterBehavior{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // right here we map our buttons wether is looking right or left according to out, Unity Input set setup. 
        var right = inputState.GetButtonValue(inputButtons[0]);
        var left = inputState.GetButtonValue(inputButtons[1]);

        // for debugging purposes. Checks if right or left are being pressed.
        if (right)
        {
            inputState.direction = Directions.right;
        }else if (left)
        {
            inputState.direction = Directions.left;
        }
        transform.localScale = new Vector3(((float)inputState.direction)*40, 40 , 1);

    }
}
