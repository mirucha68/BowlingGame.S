using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagement : MonoBehaviour
{
    public Text scoretext;�@//�X�R�A�e�L�X�g
    
    private int score; // �X�R�A
    private int judge; //�s�����Œ肳��鐔�𐧌䂷�邽�ߗp��

    public static ScoreManagement instance;�@//13-20�͑���script�Ő��䂷�邽��
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    Rigidbody rigid;�@//�{�[���̈ʒu���m�F���邽��
    

    //bool One;

    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "";
        score = 0;
        judge = 0;

        rigid = GameObject.Find("BowlingBased").GetComponent<Rigidbody>();�@//�{�[�����擾
          
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        
        float pos = rigid.transform.position.z;

        if (pos > 130�@&& judge < 1600 && judge > 500)
        {
                PinManeger.instance.Listmaking();
             
        }
        if (pos > 130 && judge < 500)
        {
            PinManeger.instance.GoodNight();

        }


    }

   
    
    public void Fight()
    {
        score += 100;
        judge += 10;

        SetCountText();
    }
    public void Omurice()
    {
        score += 10;
        judge += 1;

        SetCountText();
    }


    void SetCountText()
    {
        
        GameObject bowling = GameObject.FindWithTag("bowling");
        if (bowling.transform.position.z > 130)
        {
            // �ŏI�̃X�R�A�̕\��
            scoretext.text = "Count: " + score.ToString();
            Debug.Log("Judge"+judge.ToString());
        }

    }
}
