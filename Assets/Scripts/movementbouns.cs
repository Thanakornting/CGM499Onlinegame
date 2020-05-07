using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class movementbouns : MonoBehaviour
{
    public float speed = 5;
    //private Animator animator;
    [SerializeField]
    private string Namescenload;
    //private AudioSource audioSource;
    //public GameObject ps;
    //private float delayLoading = 5f;
    //private bool die;

    


    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        //animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");



        GetComponent<Rigidbody2D>().velocity = new Vector2(h, v) * speed;
        //audioSource.PlayOneShot(walk);
        GetComponent<Animator>().SetInteger("x", (int)h);
        GetComponent<Animator>().SetInteger("y", (int)v);



    }

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //if (collision.gameObject.name == "Enemy")
    //{
    //speed = 0;
    //}

    //}



    private void LoadScene()
    {

        SceneManager.LoadScene(Namescenload);
    }

}
