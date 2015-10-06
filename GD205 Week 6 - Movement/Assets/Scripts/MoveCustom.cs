using UnityEngine;
using System.Collections;

public class MoveCustom : MonoBehaviour {

	public GameObject[] moveables;
	public int xSpeed;
	public int ySpeed;
	public int zSpeed;
	Vector3 movement;

	// Use this for initialization
	void Start () {
		movement = new Vector3(xSpeed, ySpeed, zSpeed);
	}
	
	// Update is called once per frame
	void Update () {

		foreach (GameObject thingToMove in moveables){
			thingToMove.transform.position += movement;
		}
	}
}
