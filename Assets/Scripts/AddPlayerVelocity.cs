using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    [SerializeField]
    KeyCode keyPositive;

    [SerializeField]
    KeyCode keyNegative;

    //called exactly 100 times per second
    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Force; //+= means we will add the value to every frame

        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force; //-= means we will subtract the value to every frame


    }
}
