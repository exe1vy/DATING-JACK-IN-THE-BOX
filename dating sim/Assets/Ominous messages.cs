using TMPro;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public void ScaryMessages()
    {
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int randomScene;
        do
        {
            randomScene = Random.Range(3, sceneCount);
        } while (randomScene == currentSceneIndex);
        SceneManager.LoadScene(randomScene);
    }
}
