using UnityEngine;
using System.Collections;

public class theForce : MonoBehaviour {

	public GameObject destinationObject;
	public Vector3 destinationPoint;

	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
		destinationPoint = destinationObject.transform.position;
		//Debug.Log("destination = " + destinationPoint);

		GetComponent<Rigidbody>().AddForce(Vector3.Normalize(destinationPoint - transform.position) * 2);	

		Debug.Log(GetComponent<Rigidbody>().velocity);
		// transform.forward means... Vector3(0,0,1)
	}

	void OnCollisionEnter(Collision anyCollision){ //Collision creating a collision report... the title of the report is "anyCollision"
		Destroy(anyCollision.gameObject);

		Debug.Log("collided with " + anyCollision.gameObject);
		GetComponent<Rigidbody>().velocity = Vector3.zero; //same as new Vector3(0,0,0)

		if (anyCollision.gameObject == destinationObject){

			Debug.Log("AWWW CUTE COLLISION HURTS");
		}


	}
}
