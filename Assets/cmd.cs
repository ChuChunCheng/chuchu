using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cmd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		



	}

    public void doPlay()
    {
        Debug.Log("doPlay");
        SceneManager.LoadScene("0316");
    }

    public void doExit()
    {
        Debug.Log("doExit");
        Application.Quit();
    }
}
