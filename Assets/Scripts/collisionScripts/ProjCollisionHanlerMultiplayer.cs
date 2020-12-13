using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProjCollisionHanlerMultiplayer : MonoBehaviour
{

    [SerializeField] GameObject explosion;
    [SerializeField] float loadDelay = 2.0f;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag.Equals("Enemy"))
        {  
            //if player gets hit,then the player dies
             //disables the controls
            SendMessage("PlayerHasDied"); //called by string reference to method in player movement
            DoDeathSequence(); //enable explosion
            //reload the scene 
            Invoke("ReloadScene", loadDelay); //load delay to the reload scene 0
            //Destroy(gameObject);
        }
       
    }


    private void DoDeathSequence()
    {
        explosion.SetActive(true);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(8); //reload to scene 0
    }
}
