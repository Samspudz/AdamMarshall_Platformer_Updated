using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBallLauncher : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject spikeBall;
    public float interval = 1f;
    public float velocity = 1f;

    void Start()
    {
        StartCoroutine(Launch());
        
    }

    void Update()
    {
        
    }

    IEnumerator Launch()
    {
        while (true) 
        {
            yield return new WaitForSeconds(interval);

            GameObject ball = (GameObject) Instantiate(spikeBall, transform.position, Quaternion.identity);
            
            rb = ball.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0, velocity);
        }
    }
}
