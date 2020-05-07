using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadlevelTime : MonoBehaviour {

    [SerializeField]
    private float delayLoading = 3f;
    [SerializeField]
    private string Namescenload;

    private float timeElapsed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;
		
        if (timeElapsed > delayLoading)
        {
            SceneManager.LoadScene(Namescenload);
        }
	}
}
