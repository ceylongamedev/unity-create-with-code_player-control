using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20.0f;

    //private variables
    private float _turnSpeed = 25.0f;
    private float _horizontalInput;
    private float _forwardInput;

    void Update()
    {
        //get Horizontal and vertical  inputs
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        //move vehicle forward
        transform.Translate(Vector3.forward * speed * _forwardInput * Time.deltaTime);

        //rotate vehicle left and right
        transform.Rotate(Vector3.up, _turnSpeed * _horizontalInput * Time.deltaTime);

    }//update

}//class