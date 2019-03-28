using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToObject : MonoBehaviour
{
    public Rigidbody RigidBody;

    public void ApplyForce()
    {
        RigidBody.AddForce(0f, -300f, 0f, ForceMode.Force);
    }
}
