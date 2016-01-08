using UnityEngine;
using System.Collections;

public class CameraFPS : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + offset;
		Perspective ();
	}

	void Perspective() {
		float lookHorizontal = Input.GetAxis ("Mouse X");
		float lookVertical = Input.GetAxis ("Mouse Y");
		Vector3 sight = new Vector3 (lookVertical, lookHorizontal, 0f);
		transform.Rotate (sight);
	}
}
