using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundimplemt : MonoBehaviour
{
    public AudioSource clip;
    public GameObject gameObjectt;
    public GameObject item;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            clip.Play();
            item.SetActive(false);
            gameObjectt.GetComponent<hpjugador>().hp += 10;
        }
    }
}
        
