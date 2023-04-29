using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZoneScript : MonoBehaviour
{
    public GameObject Player;
    public Transform RespawnPoint;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            Player.transform.position = RespawnPoint.position;
            GameManager.instance.lives--;
        }
    }
}
