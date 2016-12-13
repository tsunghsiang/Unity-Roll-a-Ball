using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	/*
	private Rigidbody cube; // Hold the reference to the rigid body we want to access

	// Use this for initialization
	void Start(){
		print ("Enter into function 'Start()'");

		cube = GetComponent<Rigidbody>();

		float yAngle = 0.0f;
		foreach (Transform item in cube.transform){
			// Initialize the original location of each object
			item.transform.RotateAround(new Vector3(0.0f, 0.0f ,0.0f), new Vector3(0.0f, 1.0f ,0.0f), yAngle);
			yAngle += 10.5f;
			print("Rotate cube " + item.childCount.ToString() + " by " + yAngle.ToString() + " degrees.");
		}
		print ("Leave function 'Start()'");
	}*/

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(15,30,45) * Time.deltaTime, Space.Self);
	}
}
