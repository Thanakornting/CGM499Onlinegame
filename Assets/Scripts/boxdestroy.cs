using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxdestroy : MonoBehaviour
{

    private Animator animator;
    //[SerializeField]
    //private string anime;


    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "die")
        {
            
            animator.Play("boxbom");
            
        }
    }
}