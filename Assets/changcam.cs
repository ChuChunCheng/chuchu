using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changcam : MonoBehaviour
{


    public GameObject cam1, cam2; //兩個不同的攝影機



    // Use this for initialization
    void Awake()
    {
        cam2.SetActive(false);
        cam1.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("z") == true)
        {
            //若是按下鍵盤的z則切換成第二部攝影機
            cam1.SetActive(false);
            cam2.SetActive(true);

        }
        else if (Input.GetKey("x") == true)
        {
            //若是按下鍵盤的x則切換成第一部攝影機
            cam2.SetActive(false);
            cam1.SetActive(true);
        }
    }
}
