using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {


    public float Speed;
  //  public CapsuleCollider sc;
    Rigidbody rb;


    void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject,5);

    }

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, 5);
        //rb.AddForce(Vector3.forward * Speed * Time.deltaTime);
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
