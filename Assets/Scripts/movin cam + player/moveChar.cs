using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveChar : MonoBehaviour
{

    public KeyCode moveLeft;
    public KeyCode moveRight;

    public float horizVel = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 6);

        if (Input.GetKeyDown(moveLeft))
        {
            horizVel = -2;
            StartCoroutine(stopSlide());
        }

        IEnumerator stopSlide()
        {
            yield return new WaitForSeconds(.5f);
            horizVel = 0;
        }



    }
}
