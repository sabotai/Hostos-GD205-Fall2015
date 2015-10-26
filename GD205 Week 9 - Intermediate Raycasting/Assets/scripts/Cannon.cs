using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {

	public Rigidbody bulletBlueprint; // assign in inspector
	public Transform bulletOrigin; //position an object to use its position as a spawn point
	public float bulletForce = 3000f; //this is the bullet speed.  3000 is the default

	bool rotateToClick = false;
	Quaternion originalRot;
	Quaternion newRot;

	Rigidbody bullet;
	float rotCount = 0f;

	// Update is called once per frame
	void Update () {
		// generate a ray based on camera position + mouse cursor screen coordinate
		Ray ray = Camera.main.ScreenPointToRay ( Input.mousePosition );
		
		// reserve space for info about where the raycast hit a thing, what it hit, etc.
		RaycastHit rayHit = new RaycastHit(); // initialize forensics data container
		
		// actually shoot the raycast, 1000 is how far the raycast can go
		if ( Physics.Raycast ( ray, out rayHit, 1000f ) && Input.GetMouseButtonDown (0) ) {
			
			newRot = Quaternion.LookRotation(rayHit.point - transform.position);

			rotateToClick = true; //trigger the rotation of our camera and its children (our shooting thing)
			rotCount = 0; //reset our counter representing our rotation's % completed
		}

		if (rotateToClick){ //only do this once there was a hit ^
			float rotSpeed = Time.deltaTime; //go by time -- this will be the percentage to rotate each frame
			rotCount += rotSpeed; // count those percentages so we know how close we are
			Debug.Log("Barrel rotated by... " + rotCount*100f +"%"); //show us the % completed

			//use "slerp" to rotate smoothly
			transform.rotation = Quaternion.Slerp(transform.rotation, newRot, rotSpeed);

			if (rotCount > 1f){
				//create a new bullet instance from our blueprint
				Rigidbody newBullet = (Rigidbody)Instantiate ( bulletBlueprint, bulletOrigin.position, bulletOrigin.rotation ); // make a new clone at raycast hit position

				//make the new bullet go forward by this much force
				newBullet.AddForce(bulletOrigin.forward * bulletForce);
				GetComponent<AudioSource>().Play();
				//stop rotating every frame
				rotateToClick = false;
			}
		}


		
	}
}
