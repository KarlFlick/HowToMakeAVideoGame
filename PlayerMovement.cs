using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	//This is the reference to the Rigidbody component called "rb"
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	// We marked this as "Fixed"Update because we
	// are using it to mess with physics.
	// Update is called once per frame
	void FixedUpdate () 
	{
		//Add a forward force
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);	

		if (Input.GetKey("d"))
		{
			//Only executed if condition is met
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
	}

		if (Input.GetKey("a"))
		{
			//Only executed if condition is met
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager> ().EndGame();
		}
}
}
