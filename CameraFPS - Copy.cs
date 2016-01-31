using UnityEngine;
using System.Collections;

public class CameraFPS : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
        //Set the distance from the camera to the player as a variable.
		offset = transform.position - player.transform.position;
	}
	
	// Using LateUpdate ensures the player has moved before updating.
	void LateUpdate () {
        //Change the camera's position according to the player's movement, so it keeps the same place in relation to the player GameObject.
		transform.position = player.transform.position + offset;
		
	}

    // Call the look-around function in FixedUpdate for a regular interval.
    void FixedUpdate()
    {
        Perspective();
    }

	void Perspective() {
        //Set each variable for looking around to axes of the computer mouse's movement from the player's Input.
		float lookHorizontal = Input.GetAxis ("Mouse X");
		float lookVertical = Input.GetAxis ("Mouse Y");

        //Have the looking controls movement
        transform.Rotate(Vector3.up, lookHorizontal, Space.World);
        transform.Rotate(Vector3.right, lookVertical);
    
    }
}
