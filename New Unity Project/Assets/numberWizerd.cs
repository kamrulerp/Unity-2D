using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberWizerd : MonoBehaviour {
    int count = 0;
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Use this for initialization
    void Start () {
       

        Debug.Log("The highest number is : " + max);
        Debug.Log("The lowest number is : " + min);
        Debug.Log("You Entered Now ...");

        Debug.Log(count);
        max = max + 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You Entered Up arrow key");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You entered down arrow key");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You entered Enter Key");
            count++;
            Debug.Log("Enter key pressed :" + count + "times");
        }
       
	}
}
