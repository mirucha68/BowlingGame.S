using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BowlingController : MonoBehaviour
{
    public Text judgementText; //�Ӂ[�̋�����UI�ɕ\��
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
            if (Input.GetKey(KeyCode.W)) //�Ӂ[�̏ꏊ
            {
                rb.AddForce(0, 0, 20.0f, ForceMode.Force);
            }

            if (Input.GetKey(KeyCode.D))//�E�ړ�
            {
                rb.AddForce(2.0f, 0, 0);
            }

            if (Input.GetKey(KeyCode.A))//���ړ�
            {
                rb.AddForce(-2.0f, 0, 0);
            }

        }
        

    }

    void SetJudgementText()
    {
        if (rb.velocity.magnitude > 20f)//����҂̂Ӂ[
        {
            judgementText.text = "Excellent!!";
            ScoreManagement.instance.Fight();
        }
        else if (rb.velocity.magnitude > 10f)//�܂��܂����N�̂Ӂ[
        {
            judgementText.text = "Great!";
            ScoreManagement.instance.Omurice();
        }
        else if (rb.velocity.magnitude > 0f)//����΂낤�̂Ӂ[
        {
            judgementText.text = "Good";
        }
    }
    

}
    

