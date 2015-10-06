using UnityEngine;
using System.Collections;

public class MoveThese : MonoBehaviour {

	public GameObject[] moveables;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*
		//Here is a traditional for loop, so we can move things
		for (int i=0; i < moveables.Length; i++){
			moveables[i].transform.position += new Vector3( 0f, 0f, 0.1f );
		}
		*/


		//Here is a cleaner C# way to do the exact same thing
		
		foreach (GameObject thingToMove in moveables){
			thingToMove.transform.position += new Vector3( 0f, 0f, 0.1f );
		}
		

		
	
	}
}
