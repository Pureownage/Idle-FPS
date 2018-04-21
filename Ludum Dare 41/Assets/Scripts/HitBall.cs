using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class HitBall : MonoBehaviour
{
    public Slider powerbar;
    Rigidbody rb;
    public float barSpeed;
    bool poweringUp;
    bool powerUpOrDown = true;



    Vector3 mousePosition;


    AudioSource audio1;
    public AudioSource audio2;

    public float rotationSpeed = 100.0F;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio1 = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        audio2.Play();
    }


    // Here, we go up or down with the power bar.
    void ChangePowerBar()
    {
        audio2.enabled = true;
        // If we want to go up, powerUpOrDown becomes true;
        if (powerUpOrDown == true)
        {
            // We change the value of the powerbar
            powerbar.value = powerbar.value + barSpeed;
            if (powerbar.value == powerbar.maxValue)
            {
                powerUpOrDown = false;
            }
        }
        else
        {
            if (powerbar.value == powerbar.minValue)
            {
                powerUpOrDown = true; ;
            }
            powerbar.value = powerbar.value - barSpeed;
        }
    }

    private void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (rb.velocity.magnitude == 0)
        {
            if (Input.GetKey("space"))
            {
                ChangePowerBar();
            }
            if (Input.GetKeyUp("space"))
            {
                //rb.velocity = new Vector3(0f, 0, 0);
                Debug.Log("Shot Speed is : " + powerbar.value);
                rb.AddForce(transform.forward * powerbar.value, ForceMode.Impulse);
                audio1.volume = powerbar.value / 1000;
                audio1.Play();
                // TO DO: Make this much more gracious. It doesn't look good with it instantly gsnapping back to 0
                powerbar.value = 0;
            }

        }
        else
        {
        }
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }
}
