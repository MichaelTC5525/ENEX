using UnityEngine;
using System.Collections;

public class DayNight : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Vector3 sky = new Vector3 (1, 1, 1);
		transform.Rotate (sky * Time.deltaTime);
	}
}
