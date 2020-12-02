using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Utilities;

public class SceneController : MonoBehaviour
{

    //menu
    public void NewGame()
    {
        SceneManager.LoadSceneAsync(SceneNames.LEVELONE);
    }

    public void LoadGame()
    {
        SceneManager.LoadSceneAsync(SceneNames.LEVELONE);
    }

    public void Multiplayer()
    {
        SceneManager.LoadSceneAsync(SceneNames.LEVELONE);
    }

    public void SoundOff()
    {
        SceneManager.LoadSceneAsync(SceneNames.OptionsMenu);
    }

    public void Quit()
    {
        Application.Quit();
    }


    public static SceneController FindSceneController()
    {
        SceneController sc = FindObjectOfType<SceneController>();
        if (!sc)
        {
            Debug.LogWarning("Missing SceneController");
        }
        return sc;
    }

}
