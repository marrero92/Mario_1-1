using UnityEngine;
using System.Collections;

// we cannot instantiate it directly
public abstract class CharacterBehavior : MonoBehaviour {

    //array for all the buttons
    public Buttons[] inputButtons;

    // out side classes cannot access. Only available on extended classes.
    protected InputState inputState;
    protected Rigidbody2D rb;
    protected CollisionState collisionState;

    // to retain start cycle events
   protected virtual void Awake()
    {
        inputState = GetComponent<InputState>();
        rb = GetComponent<Rigidbody2D>();
        collisionState = GetComponent<CollisionState>(); ;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
