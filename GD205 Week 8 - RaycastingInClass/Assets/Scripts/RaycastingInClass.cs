using UnityEngine;
using System.Collections;

public class RaycastingInClass : MonoBehaviour {

	public Transform blueprint;


	// Update is called once per frame
	void Update () {
	
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition);
		RaycastHit rayHit = new RaycastHit();

		if (Physics.Raycast(ray, out rayHit, 1000f)){


			if (Input.GetMouseButtonDown(0)){
				Debug.Log("CYCLOPS WINZ at " + rayHit.point);
				transform.LookAt(rayHit.point);
				Instantiate(blueprint, rayHit.point, Random.rotation);

			} else if (Input.GetMouseButtonDown(1)){
				GameObject temp = rayHit.transform.gameObject;
				Debug.Log("You hit something tagged with " + temp.tag);

				if (temp.tag == "destructable"){
					Destroy(rayHit.transform.gameObject);
				}

			}

		}
	}	 
}
