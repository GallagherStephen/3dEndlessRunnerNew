using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPoweUp : MonoBehaviour
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

        //player.transform.localScale *= multiplier;

        Destroy(gameObject); //destroy shield
    }




}
