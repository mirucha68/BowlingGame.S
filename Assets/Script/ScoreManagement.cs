using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagement : MonoBehaviour
{
    public Text scoretext;　//スコアテキスト
    
    private int score; // スコア
    private int judge; //ピンが固定される数を制御するため用意

    public static ScoreManagement instance;　//13-20は他のscriptで制御するため
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    Rigidbody rigid;　//ボールの位置を確認するため
    

    //bool One;

    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "";
        score = 0;
        judge = 0;

        rigid = GameObject.Find("BowlingBased").GetComponent<Rigidbody>();　//ボールを取得
          
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        
        float pos = rigid.transform.position.z;

        if (pos > 130　&& judge < 1600 && judge > 500)
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
            // 最終のスコアの表示
            scoretext.text = "Count: " + score.ToString();
            Debug.Log("Judge"+judge.ToString());
        }

    }
}
