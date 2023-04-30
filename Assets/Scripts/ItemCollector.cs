using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    [SerializeField] private Text melonsText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Melon"))
        {
            Destroy(collision.gameObject);
            GameManager.instance.melons++;
            melonsText.text = "Melons: " + GameManager.instance.melons;
            collectionSoundEffect.Play();
        }
    }
}
