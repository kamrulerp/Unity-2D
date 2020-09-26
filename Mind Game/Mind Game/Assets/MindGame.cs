using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MindGame : MonoBehaviour {
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

	// Use this for initialization
	void Start () {
        state = startingState;
        textComponent.text = state.getStory();
	}
	
	// Update is called once per frame
	void Update () {
        manageState();
	}

    private void manageState()
    {
        var nextState = state.getNextState();

        if (Input.GetKeyDown(KeyCode.N))
        {
            state = nextState[0];
        }else if (Input.GetKeyDown(KeyCode.P))
        {
            state = nextState[1];
        }
        else
        {
            
        }
        textComponent.text = state.getStory();
    }
}
