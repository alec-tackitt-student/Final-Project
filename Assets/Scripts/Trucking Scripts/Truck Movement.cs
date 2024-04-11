using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class TruckMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardAccel = 6f, reverseAccel = 4f, maxSpeed = 50f, turnStrength = 50, gravityForce = 5f;

    private float speedInput, turnInput;

    private bool grounded;

    public LayerMask whatIsGround;
    public float groundRayLength = .5f;
    public Transform groundRayPoint;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.transform.parent = null;
    }

    private void Update()
    {
        speedInput = 0f;
        if(Input.GetAxis("Vertical") > 0)
        {
            speedInput = Input.GetAxis("Vertical") * forwardAccel * 5f;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            speedInput = Input.GetAxis("Vertical") * reverseAccel * 5f;
        }
        turnInput = Input.GetAxis("Horizontal");

        
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStrength * Time.deltaTime , 0f));
       
        transform.position = rb.transform.position;
    }

    private void FixedUpdate()
    {
        grounded = false;
        RaycastHit hit;

        if (Physics.Raycast(groundRayPoint.position, -transform.up, out hit, groundRayLength, whatIsGround))
        {
            grounded = true;
        }


        if (Mathf.Abs(speedInput) > 0)
        {
            rb.AddForce(transform.right * speedInput);
        }
    }
}
