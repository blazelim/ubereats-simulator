using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Is insurance going to pay for that?");
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Why is my food cold?");
    }
}
