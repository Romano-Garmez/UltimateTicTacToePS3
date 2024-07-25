using UnityEngine;
using System.Collections;

public class virtualMouse : MonoBehaviour {

	public float speed = 20f; // Speed of the cursor movement
    private Vector3 cursorPosition;
	// Use this for initialization
	void Start () {
		cursorPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// Get input from the left stick
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Update the cursor position based on input
        cursorPosition += new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;

        // Clamp the cursor position to the screen bounds (optional)
        //cursorPosition.x = Mathf.Clamp(cursorPosition.x, 0, Screen.width);
        //cursorPosition.y = Mathf.Clamp(cursorPosition.y, 0, Screen.height);

        // Apply the new position to the cursor GameObject
        transform.position = cursorPosition;
	}
}
