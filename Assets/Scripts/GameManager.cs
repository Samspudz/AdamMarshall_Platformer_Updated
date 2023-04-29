using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int lives = 3;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        /*if (melons == 5)
        {
            SceneManager.LoadScene("VictoryScene");
            melons = 0;
        }*/

        if (lives == 0) 
        {
            SceneManager.LoadScene("GameOverScene");
            lives = 3;
        }
    }
}
