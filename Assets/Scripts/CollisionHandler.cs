using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("collided with something");
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Trigger from collision");
    }
}
