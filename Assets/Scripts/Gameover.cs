using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    Text heal;
    public static int healty;
    [SerializeField]
    private string Namescenload;
    //public int healty = 3;
    //public Text heal;

    // Use this for initialization
    void Start()
    {
        //StartCoroutine("aaaa");
        healty = 3;
        //Debug.Log(5555);
        heal = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        heal.text = ("left1" + healty);
        if (healty <= 0)
        {
            Invoke("LoadScene", 3f);
            //SceneManager.LoadScene(Namescenload);

            //StopCoroutine("aaaa");
            heal.text = "Over";
        }

        //heal.text = "LEFT3" + healty;
        //heal.text = ("LEFT3" + healty);
        //heal.text = "LEFT3" + healty;
        //if (healty <= 0)
        //{
        //Invoke("LoadScene", 3f);
        //SceneManager.LoadScene(Namescenload);


        //heal.text = "LEFT3";
        //StartCoroutine("LoseTimee");

        //}
    }
    private void LoadScene()
    {

    SceneManager.LoadScene(Namescenload);
    }
    
}
