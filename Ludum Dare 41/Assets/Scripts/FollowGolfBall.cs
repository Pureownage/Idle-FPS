using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGolfBall : MonoBehaviour {

    public Transform GolfBall;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(GolfBall.transform.position.x, GolfBall.transform.position.y + 10, GolfBall.transform.position.z);



       // offset = target.transform.position - transform.position;
    
}
}
