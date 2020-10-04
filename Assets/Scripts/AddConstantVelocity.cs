using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    //called exactly 100 times per second
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += v3Force; //+= means we will add the value to every frame
    }
}
