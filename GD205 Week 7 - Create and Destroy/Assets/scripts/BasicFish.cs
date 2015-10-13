using UnityEngine;
using System.Collections;

public class BasicFish : MonoBehaviour {

	public GameObject foodPellet; // assign in inspector
	public Vector3 destination; //public so we can see what the destination is
	public float speed = 0.2f; //set the speed

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {


	
		destination = foodPellet.transform.position;
	

		// is the fish within a unit of its destination? then stop swimming and destroy the pellet
		//if ( Vector3.Distance(destination, transform.position) > 1f) {
			GetComponent<Rigidbody>().AddForce ( Vector3.Normalize(destination - transform.position) * speed );
		//}  else {
		//	GetComponent<Rigidbody>().velocity = Vector3.zero; // come to complete stop
		//}

	}
}
