using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
