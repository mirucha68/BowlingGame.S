using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BowlingController : MonoBehaviour
{
    public Text judgementText; //ふーの強さでUIに表示
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        judgementText.text = "";


    }

    // Update is called once per frame
    
    void FixedUpdate()
    {
        SetJudgementText();
        float p = this.transform.position.z;

        if ( p < 130)
        {
            if (Input.GetKey(KeyCode.W)) //ふーの場所
            {
                rb.AddForce(0, 0, 20.0f, ForceMode.Force);
            }

            if (Input.GetKey(KeyCode.D))//右移動
            {
                rb.AddForce(2.0f, 0, 0);
            }

            if (Input.GetKey(KeyCode.A))//左移動
            {
                rb.AddForce(-2.0f, 0, 0);
            }

        }
        

    }

    void SetJudgementText()
    {
        if (rb.velocity.magnitude > 20f)//健常者のふー
        {
            judgementText.text = "Excellent!!";
            ScoreManagement.instance.Fight();
        }
        else if (rb.velocity.magnitude > 10f)//まあまあ健康のふー
        {
            judgementText.text = "Great!";
            ScoreManagement.instance.Omurice();
        }
        else if (rb.velocity.magnitude > 0f)//がんばろうのふー
        {
            judgementText.text = "Good";
        }
    }
    

}
    

