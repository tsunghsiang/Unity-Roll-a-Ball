using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class PlayController : MonoBehaviour {

	public float speed;    // The variable used to adjust the speed of an object
	public Text CountText; // Hold the reference to the UI texts or componenets on our UI text game object
	public Text WinText;   // Hold the reference to the UI texts or componenets on our UI text game object

	private Rigidbody rb;  // Hold the reference to the rigid body we want to access
	private int count;     // Count the collectable game objects that is picked up

	// Called on the 1st frame that the script is active
	void Start() {
		rb = GetComponent<Rigidbody>();
		count = 0;
		setCountText ();
		WinText.text = "";
	}

	// Called before performing any physics animations
	void FixedUpdate(){
		// Grab inputs from our player through the keyboard
		float moveHorizontal = Input.GetAxis ("Horizontal"); 
		float moveVertical   = Input.GetAxis ("Vertical");

		// Dtermine the direction of the force we'll add to our ball
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		// Apply force to the ball
		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			setCountText ();
			setWinText ();
		}
	}

	void setCountText(){
		// Update the text as we pick up a new collectable
		CountText.text = "Count: " + count.ToString ();		
	}

	void setWinText(){
		// Update the text if the specified amount of collectable is picked up
		if(count >= 12){
			WinText.text = "You Win!";	
		}
	}
}
