using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Pot : MonoBehaviour {

    public Text victoryText;
    GameManager gm;

    AudioSource audio1;



	// Use this for initialization
	void Start () {
        gm = FindObjectOfType<GameManager>();
        audio1 = GetComponent<AudioSource>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Golf Ball")
        {
            Debug.Log("We hit the ball!");
            victoryText.enabled = true;
            audio1.Play();
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
