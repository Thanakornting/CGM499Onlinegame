using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    public float speed;
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Changedir", 0, 0.5f);
        animator = GetComponent<Animator>();
    }

    private Vector2 Randir()
    {
        int r = Random.Range(-1, 2);
        return (Random.value < 0.5) ? new Vector2(r, 0) : new Vector2(0, r);
    }

    private bool IsValid(Vector2 dir)
    {
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider.gameObject == gameObject);
    }

    private void Changedir()
    {
        Vector2 dir = Randir();

        if (IsValid(dir))
        {
            GetComponent<Rigidbody2D>().velocity = dir * speed;
            // GetComponent<Animator>().SetInteger("x", (int)dir.x);
            //GetComponent<Animator>().SetInteger("y", (int)dir.y);
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //if (collision.gameObject.name == "Player")
    //{
    //Invoke("LoadScene", 3f);
    //Destroy(collision.gameObject, 2f);
    //}

    //if (collision.gameObject.name == "Player")
    //{
    //Destroy(collision.gameObject, 1f);

    //Application.LoadLevel(5);
    //Invoke("Application.LoadLevel", 5);
    //}

    //}
    private void LoadScene()
    {
        //SceneManager.LoadScene(5);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "die")
        {
            speed = 0;
            animator.Play("aidie0");
            //animator.SetTrigger("aidie0");
        }
    }
}
