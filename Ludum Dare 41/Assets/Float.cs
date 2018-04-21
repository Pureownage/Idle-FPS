using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour {

    float floating;
    GameObject parentLocation;
    bool upOrDown = true;

    public Transform GolfBall;
    public float amp;
    public float speed;

    // Use this for initialization
    void Start () {
        parentLocation = transform.parent.gameObject;

    }

    private void FixedUpdate()
    {
        float tempY = transform.position.y;
        tempY = tempY + amp * Mathf.Sin(speed * Time.time);
        //transform.position = new Vector3(transform.position.x, tempY, transform.position.z);
        Vector3 targetPostition = new Vector3(GolfBall.position.x,this.transform.position.y, GolfBall.position.z);
        this.transform.LookAt(targetPostition);
        transform.LookAt(2*transform.position - targetPostition);
    }

    // Update is called once per frame
    void Update () {

        if(floating >= 1.0f || floating <=1.0f)
        {
            upOrDown = !upOrDown;
        }
        if (upOrDown)
        {
            floating+= 0.01f;
        }
        else
        {
            floating -= 0.01f;
        }
	}
}
