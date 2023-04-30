using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScript : MonoBehaviour
{
    [SerializeField] private AudioSource victorySound;
    [SerializeField] private float goToNextSceneTime = 2f;

    private void Start()
    {
        victorySound = GetComponent<AudioSource>();    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.name == "Player") && (GameManager.instance.melons == 10))
        {
            GameManager.instance.melons = 0;
            victorySound.Play();
            Invoke("CompleteLevel", goToNextSceneTime);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene("VictoryScene");
    }
}
