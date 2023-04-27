using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{
    public string sceneName;

    void Start()
    {

    }

    void Update()
    {

    }

    public void GoToNewScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}