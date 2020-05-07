using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class movement : NetworkBehaviour
{
    [SerializeField]
    public Transform bombdrop;
    public GameObject bombPrefab;
    public float speed = 5;
    private Animator animator;
    
    public string Namescenload;
    //private AudioSource audioSource;
    //public GameObject ps;
    //private float delayLoading = 5f;
    //private bool die;

    public AudioClip walk;


    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            CmdDropBomb();

        }
        if (!isLocalPlayer)
        {
            return;
        }
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

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "die")
        {
            Invoke("LoadScene", 3f);
            animator.Play("dead");
            speed = 0;
            Gameover.healty -= 1;
            other.GetComponent<Collider2D>().enabled = false;

            //SceneManager.LoadScene(5);
        }

        if (other.tag == "Enemy")
        {
            Invoke("LoadScene", 3f);
            speed = 0;
            animator.Play("dead");
            Gameover.healty -=1;
        }
        if (other.tag == "Enemy2")
        {
            Invoke("LoadScene", 3f);
            speed = 0;
            animator.Play("dead");
            Gameover.healty -= 1;
        }
        if (other.tag == "Enemy3")
        {
            Invoke("LoadScene", 3f);
            speed = 0;
            animator.Play("dead");
            Gameover.healty -= 1;
        }
        if (other.tag == "Enemy4")
        {
            Invoke("LoadScene", 3f);
            speed = 0;
            animator.Play("dead");
            Gameover.healty -= 1;
        }
        if (other.tag == "Enemy5")
        {
            Invoke("LoadScene", 3f);
            speed = 0;
            animator.Play("dead");
            Gameover.healty -= 1;
        }

        if (other.tag == "Pickup")
        {
            other.gameObject.SetActive(false);
            speed += 1;
        }
        if (other.tag == "Pickup1")
        {
            other.gameObject.SetActive(false);
            
        }




    }

    public override void OnStartLocalPlayer()
    {
        //base.OnStartLocalPlayer();
      //  if (!isLocalPlayer)
       // {
        //    return;
       // }
    }


    [Command]
    void CmdDropBomb()
    {
        GameObject Bomb1 = (GameObject)Instantiate(bombPrefab, bombdrop.position, bombdrop.rotation);
        //Instantiate(bombPrefab, this.gameObject.transform.position, Quaternion.identity);
        
       NetworkServer.Spawn(Bomb1);
       // if (!isLocalPlayer)
     // {
       //    return;
      //  }
    }
    private void LoadScene()
    {

        SceneManager.LoadScene(Namescenload);
    }
    

    
    
       
    

  

}