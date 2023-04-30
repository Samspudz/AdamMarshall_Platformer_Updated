using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    private Animator anim;

    [SerializeField] private Transform Checkpoint;
    [SerializeField] private GameObject RespawnPoint;

    [SerializeField] private AudioSource CheckpointSoundEffect;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("CheckpointActive", true);
            RespawnPoint.transform.position = Checkpoint.position;
        }
    }
}
