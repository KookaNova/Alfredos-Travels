using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public float thrust;
    public Rigidbody RigidBody;

    void Start()
    {
        RigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        RigidBody.AddForce(0, thrust, 0, ForceMode.Impulse);
    }
}
