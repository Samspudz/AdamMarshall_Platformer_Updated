using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int melons = 0;
    public int lives = 3;

    private void Start()
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

    private void Update()
    {
        if (melons == 5)
        {
            SceneManager.LoadScene("VictoryScene");
            melons = 0;
        }

        if (lives == 0) 
        {
            SceneManager.LoadScene("GameOverScene");
            lives = 3;
        }
    }
}
