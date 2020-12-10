using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VPNpowerUP : MonoBehaviour
{

    public float multiplier = 1.4f;

    public GameObject pickupEffect;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        //do powerup here:
        //player.transform.localScale *= multiplier;

        Destroy(gameObject); //destroy shield
    }






}
