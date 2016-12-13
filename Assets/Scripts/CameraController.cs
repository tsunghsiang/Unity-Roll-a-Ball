using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player; // Reference to the player
	private Vector3 offest;   // Hold the offset value

	// Use this for initialization
	void Start () {
		offest = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame, which is guaranteed to run after all
	// items have been processed in update
	void LateUpdate () {
		transform.position = player.transform.position + offest;
	}
}
