using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {wake, coffee, sleep, bed};
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.wake;
		
	}
	
	// Update is called once per frame
	void Update () {
        print(myState);
        switch (myState) {
            case States.wake:
                state_wake();
                break;
            case States.bed:
                state_bed();
                break;
            case States.coffee:
                state_coffee();
                break;
            case States.sleep:
                state_sleep();
                break;

        }
	}

    void state_sleep() {
        text.text = "He went back to sleep!";
    }

    void state_coffee() {
        throw new NotImplementedException();
    }

    void state_bed() {
        throw new NotImplementedException();
    }

    void state_wake() {
        text.text = "Bright rays shine into Eric's room. It's clearly past noon, and Eric has just woken up. \n\n" +
            "(A) Eric brews some coffee. \n" +
            "(S) Eric goes back to sleep. \n" +
            "(D) Eric makes his bed. \n";
        if (Input.GetKeyDown(KeyCode.A)) {
            myState = States.coffee;
        }else if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.sleep;
        }else if (Input.GetKeyDown(KeyCode.D)) {
            myState = States.bed;
        }
    }
}
