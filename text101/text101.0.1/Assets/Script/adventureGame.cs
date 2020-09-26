using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adventureGame : MonoBehaviour {
    [SerializeField] Text textContent;
    [SerializeField] State startingState;

    State state;
    
	// Use this for initialization
	void Start () {
        //textContent.text = "I'm added programetically";

        state = startingState;
        textContent.text = state.getStoryText();
	}
	
	// Update is called once per frame
	void Update () {
        ManageState();
	}

    private void ManageState()
    {
        var nextState = state.getNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextState[0];
        }else if (Input.GetKeyDown(KeyCode.Q))
        {
            state = nextState[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextState[2];
        }

        textContent.text = state.getStoryText();
    }
}
