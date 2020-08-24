using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearRotator : MonoBehaviour
{
    private Rigidbody rb;
    public float Speed;
    public Vector3 RotationAxis;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    private void FixedUpdate()
    {
        Quaternion mdeltaRotation = Quaternion.Euler(RotationAxis * Time.deltaTime);
        rb.MoveRotation(rb.rotation * mdeltaRotation);
        
    }
}
