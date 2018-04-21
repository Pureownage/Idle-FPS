using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

    public Text livesText,timeTakenText;

    int lives = 5;
    float timeTaken = 0;


	// Use this for initialization
	void Start () {
		
	}
	

    public void RemoveALife()
    {
        if(lives == 0)
        {
            Debug.Log("All Lives Lost");
        }
        else
        {
            lives -= 1;
        }

    }

    private void FixedUpdate()
    {
        timeTaken += Time.deltaTime;
    }

    // Update is called once per frame
    void Update () {
        livesText.text = "Lives: " + lives.ToString();
        timeTakenText.text = "Time Taken: " + timeTaken.ToString("00.00");
    }
}
