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

    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioSource spawnSoundEffect;

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
        }
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
        GameManager.instance.lives--;
        deathSoundEffect.Play();
        Respawn();
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(2);
        rb.bodyType = RigidbodyType2D.Dynamic;
        anim.SetTrigger("spawn");
        Player.transform.position = RespawnPoint.position;
        spawnSoundEffect.Play();
    }
}
