using UnityEngine;
using System.Collections;

//script modified and adapted from Robert Yang's Building Worlds


// 1) we made the fish go to a destination
// 2) we debugged that behavior, added a distance check
// 3) we also made it come to a full stop upon failing the distance check
// 4) we also normalized the fish's force vector, consistent move speed
// 5) we plugged the food pellet position into the "destination"

public class Fish : MonoBehaviour {

	public Vector3 destination;
	public float speed = 0.2f;
	
	public GameObject blueprint; //assign fish prefab
	public GameObject foodPellet; // assign gameobject in inspector
	Vector3 nearbyPosition;
	
	// Update is called once per frame
	void Update () {

	
		destination = foodPellet.transform.position;
		transform.LookAt(destination);
	

		// is the fish within a unit of its destination? then stop swimming and destroy the pellet
		if ( Vector3.Distance(destination, transform.position) > 1f) {
			GetComponent<Rigidbody>().AddForce ( Vector3.Normalize(destination - transform.position) * speed );
		} else {
			GetComponent<Rigidbody>().velocity = Vector3.zero; // come to complete stop

			GameObject eatenPellet = foodPellet;

			//use the function below to make a new pellet
			makePellet();
			//get rid of the old pellet since it's been eaten
			Destroy(eatenPellet);
		}


		if (Input.GetMouseButtonDown(0)){
			//make a new pellet when the user left clicks
			makePellet();
		}
	} // update

	void makePellet(){

			//instantiate a new pellet somewhere nearby
			//Random.insideUnitSphere will give you a random Vector3, with X, Y and Z values between 0 and 1
			nearbyPosition = destination + Random.insideUnitSphere * 1.5f;
			GameObject clone = Instantiate(blueprint, nearbyPosition, Quaternion.identity) as GameObject;

			//make the new pellet the our new target
			foodPellet = clone;

	}
} 
