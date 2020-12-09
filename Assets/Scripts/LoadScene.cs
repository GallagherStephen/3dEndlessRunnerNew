using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   // private GameObject player;
    public int nextSceneToLoad;

    void start()
    {
        //player = GameObject.Find("player");
       // nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
  void OnTriggerEnter(Collider other)
    {
        if(other.tag == "player")
        {
            Debug.Log("Entered");
            //PlayerPrefs.SetFloat("finalScoreValue", player.transform.position.z);
            SceneManager.LoadScene(nextSceneToLoad);
        }
      
    }
}
