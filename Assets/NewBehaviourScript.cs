using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NewBehaviourScript : MonoBehaviour {
    Rigidbody rb;

    public Text  countText;
    public Text  timeText;
    public Text  golText;

    int count;
    DateTime curr;
    public float speed;
	// Use this for initialization
	void Start () {


        rb = GetComponent<Rigidbody>();

        count = 0;
        countText.text = "分數";
        golText.text = "";

        curr = DateTime.Now;
        timeText.text = "30";
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //transform.Translate(x, 0, z);

        rb.AddForce(new Vector3(x, 0, z)*speed);

        TimeSpan ts = DateTime.Now - curr;
        if (ts.Seconds < 30){
        
        timeText.text = (30 - ts.Seconds).ToString();
        }else{
            timeText.text = "0";
            golText.text = "You lose!";
        }
	}
    void OnTriggerEnter(Collider other)
    {
        

            other.gameObject.SetActive(false);
            count++;
            countText.text = "分數:" + count.ToString();

            if (count >= 10)
            {
                golText.text = "You win!";
            }

        

    }
}
