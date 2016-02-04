using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Keep a collections of the button states value and time.
    public class ButtonSate
{

    public bool value;
    public float holdTime = 0;

}

// Represents the states of the directions.
public enum Directions
{
    right = 1,
    left = -1

}
public class InputState : MonoBehaviour {


    //add a public property that repesents the direction, every objects starts facing right.
    public Directions direction = Directions.right;

    //creates the Dictionary, Key is the buttons enum, and the value the button state
    private Dictionary<Buttons, ButtonSate> buttonStates = new Dictionary<Buttons, ButtonSate>();

    public void SetButtonValue(Buttons key, bool value)
    {
        //checks if the key exist
        if (!buttonStates.ContainsKey(key))
            buttonStates.Add(key, new ButtonSate());

        var state = buttonStates [key];

        //check if the button has been released.
        if(state.value && !value)
        {
            //Debug.Log("Button " + key + " released." + state.holdTime);
            state.holdTime = 0;

        }else if(state.value && value)
        {

                state.holdTime += Time.deltaTime;
               // Debug.Log("Button " + key + " Down " + state.holdTime);
           
        }

        state.value = value;

    }


    public bool GetButtonValue(Buttons key)
    {
        if (buttonStates.ContainsKey (key)) {
            return buttonStates[key].value;
        } else
            return false;
    }
    public float GetButtonHoldTime(Buttons key)
    {
        if (buttonStates.ContainsKey(key))
        {
            return buttonStates[key].holdTime;
        }
        else
            return 0;
    }
}
