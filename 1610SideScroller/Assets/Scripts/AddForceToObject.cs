using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToObject : MonoBehaviour
{
    public float ForceX;
    public float ForceY;
    public float ForceZ;

    public float TorqueX;
    public float TorqueY;
    public float TorqueZ;
    
    public Rigidbody RigidBody;

    public void ApplyForce()
    {
        RigidBody.AddForce(ForceX,ForceY,ForceZ, ForceMode.Force);
        RigidBody.AddTorque(TorqueX,TorqueY,TorqueZ, ForceMode.Force);
    }
    
}
