using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogeTriggerScript : MonoBehaviour
{

    public GameObject UIObject;
    public GameObject DialogeTrigger;

    // Start is called before the first frame update
    void Start()
    {
        UIObject.SetActive(false);
    }

    

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "player")
        {
            UIObject.SetActive(true);
        }
    }

    // Update is called once per frame
        void Update()
        {
        
        }

    void OntriggerExit(Collider other)
    {
        UIObject.SetActive(false);
        Destroy(DialogeTrigger);
    }
}
