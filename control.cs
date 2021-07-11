using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class control : MonoBehaviour
{
    public float PushForce = 10f;
    public float TurnForce = 45f;
    private Rigidbody rb = null;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            rb.AddForce(this.transform.forward * PushForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            rb.AddTorque(Vector3.up * -TurnForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            rb.AddTorque(Vector3.up * TurnForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
