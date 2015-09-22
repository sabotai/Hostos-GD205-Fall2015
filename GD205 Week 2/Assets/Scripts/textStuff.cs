using UnityEngine;
using System.Collections;

public class textStuff : MonoBehaviour {

    //declare some new variables(containers) of various types
    //making something "public" means you can change the assignment in the Unity editor
	public GameObject myTextObject;
	string upString;
	string downString;
	string roomName;

	// Use this for initialization
	void Start () {
        //these are the default values we are starting our game with
        //these happen to all be strings (strings of text)
		roomName = "outside";
		upString = "You look up at a starry night.";
		downString = "You gaze down to see puddles lit by moonlight";
	}
	
	// Update is called once per frame
	void Update () {

		if(roomName == "outside"){
            //only do these things if the statement above is true

            //if the player is outside, check these conditions
            if (Input.GetKeyDown("up")){
                //like... if the "up" key is pressed down, do something

                myTextObject.GetComponent<TextMesh>().text = upString;
                //this goes from general to specific, separated by periods
                //we're telling it to change the value of something to whatever upString is
                //in this case, that means myTextObject->TextMesh component->text value
			}

			if (Input.GetKeyDown("down")){
				myTextObject.GetComponent<TextMesh>().text = downString;
			}


            //end of things to be done when roomName is equal to "outside"
		} else{
            //do something else if roomName is not "outside"... this part is optional
        }
		
		if (Input.GetKeyDown("left")){
            //if the key "left" is pressed down, do the following...

            //first, change the roomName to "house"
                //remember when we checked if the roomName was "outside"?
                //now that will no longer apply, so we won't be checking for those earlier key presses
			roomName = "house";

            myTextObject.GetComponent<TextMesh>().text = "You are in a house.  The door is locked and now you're stuck :(";
        
            //that's the end of stuff to do when "left" is pressed down
        }
	}
}
