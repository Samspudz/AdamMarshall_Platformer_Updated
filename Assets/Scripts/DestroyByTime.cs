using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    [SerializeField] private float destroyTime = .3f;

    void Start()
    {
        Destroy(this.gameObject, destroyTime);
    }

}
