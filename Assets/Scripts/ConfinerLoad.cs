using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfinerLoad : MonoBehaviour
{
    public static ConfinerLoad instance;

    void Start()
    {
        if (instance == null)
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
        
    }
}
