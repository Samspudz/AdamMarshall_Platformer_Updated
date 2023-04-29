using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] private Transform RespawnPoint;
    [SerializeField] private GameObject Player;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Trap"))
        {
            Die();
            Spawn();
        }
    }

    private void Spawn()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        anim.SetTrigger("spawn");
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");

    }

    private void Respawn()
    {
        Player.transform.position = RespawnPoint.position;
        GameManager.instance.lives--;
    }
}
