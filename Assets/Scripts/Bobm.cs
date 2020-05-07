using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobm : MonoBehaviour {

    public GameObject explosionPrefab;
    //private AudioSource audioSource;

    //public AudioClip bombexpo;

    //public float time = 2;

    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        //Destroy(gameObject, time);
    }

    private void OnDestroy()
    {
        //audioSource.PlayOneShot(bombexpo);
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<Collider2D>().isTrigger = false;
    }
}
