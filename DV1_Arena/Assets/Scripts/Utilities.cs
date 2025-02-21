using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //access LoadScene
public static class Utilities //does not inherit from becuase we don't need it in the game scene
{
    public static int playerDeaths = 0; //# of times we've died & restarted the game
    public static string UpdateDeathCount(ref int countReference)
    {
        countReference += 1;//increment reference parameter by 1 & return a string that contains new value
        return "Next time you'll be at number " + countReference;
    }
    public static void RestartLevel() //hold our level restart logic
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
        Debug.Log("Player Deaths: " + playerDeaths);
        string messge = UpdateDeathCount(ref playerDeaths);
        Debug.Log("Player Deaths: " + playerDeaths);
    }
    public static bool RestartLevel(int sceneIndex) //overloaded version of RestartLevel()
    {
        SceneManager.LoadScene(sceneIndex); //passes sceneIndex parameter vs. hardcoding it
        Time.timeScale = 1.0f;
        return true; //timejScale property resets
    } 
}

