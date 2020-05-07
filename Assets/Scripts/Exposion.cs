using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exposion : MonoBehaviour {

    
    


    private void Start()
    {
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            collision.GetComponent<Collider2D>().enabled = false;
            //collision.GetComponent<SpriteRenderer>().enabled = false;
            //Destroy(collision.gameObject, 10f);

        }
        else if (!collision.gameObject.isStatic)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Destroy(collision.gameObject, 2f);
                Score.scoreValue +=50;
                
            }
            if (collision.gameObject.tag == "Enemy2")
            {
                Destroy(collision.gameObject, 2f);
                Score.scoreValue += 100;

            }
            if (collision.gameObject.tag == "Enemy3")
            {
                Destroy(collision.gameObject, 2f);
                Score.scoreValue += 150;

            }
            if (collision.gameObject.tag == "Enemy4")
            {
                Destroy(collision.gameObject, 2f);
                Score.scoreValue += 200;

            }
            if (collision.gameObject.tag == "Enemy5")
            {
                Destroy(collision.gameObject, 2f);
                Score.scoreValue += 250;

            }
            if (collision.gameObject.tag == "Player")
            {
                Destroy(collision.gameObject, 2f);
                //Score.scoreValue += 100;
            }
            if (collision.gameObject.tag == "box")
            {
                Destroy(collision.gameObject, 1f);
                //animator.Play("boxbom");

            }
            
        }
    }
 
}
