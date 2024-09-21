using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //6) public float speed = 20;

    //11) public float turnSpeed = 20;
    //12) public float horizontalInput;
    //13) public float forwardInput;

    //15) make all variables private
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;


    // Update is called once per frame
    void Update()
    {
        //12)
        horizontalInput = Input.GetAxis("Horizontal");

        //13)
        forwardInput = Input.GetAxis("Vertical");


        //1) move vehicle forward 

        //2) transform.Translate(0, 0, 1);
        //3) transform.Translate(Vector3.forward);
        //4) transform.Translate(Vector3.forward*Time.deltaTime*20);

        //5) give the objects rigid body

        //6) transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //11) transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
        //12) transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        //13)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //14)
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}
