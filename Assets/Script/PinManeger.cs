using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinManeger : MonoBehaviour
{
    //リスト化
    public List<GameObject> myList;
    public List<GameObject> useList = new List<GameObject>();
    private GameObject randomPin;
    private int choiceNum;

    

    //13-21までは呼び出しに使う
    public static PinManeger instance;　
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    bool One;
    
    
    void Start()
    {
        One = true;
        
    }
    public void Listmaking() //Greatのとき
    {
        

        if (One)　　//一回のみ実行するため
        {
            One = false;

            for (int i = 0; i < 5; i++)
            {
                //myListの中からランダムで1つを選ぶ
                randomPin = myList[Random.Range(0, myList.Count)];
                //選んだオブジェクトをuseListに追加
                useList.Add(randomPin);
                //選んだオブジェクトのリスト番号を取得
                choiceNum = myList.IndexOf(randomPin);
                //同じリスト番号をmyListから削除
                myList.RemoveAt(choiceNum);

            }

            Rigidbody rb0 = useList[0].transform.GetComponent<Rigidbody>();
            rb0.mass = 300;

            Rigidbody rb1 = useList[1].transform.GetComponent<Rigidbody>();
            rb1.mass = 300;

            Rigidbody rb2 = useList[2].transform.GetComponent<Rigidbody>();
            rb2.mass = 300;

            Rigidbody rb3 = useList[3].transform.GetComponent<Rigidbody>();
            rb3.mass = 300;

            Rigidbody rb4 = useList[4].transform.GetComponent<Rigidbody>();
            rb4.mass = 300;

        }
          
    }

    public void GoodNight()
    {
        if (One)　　//一回のみ実行するため
        {
            One = false;

            for (int i = 0; i < 7; i++)
            {
                //myListの中からランダムで1つを選ぶ
                randomPin = myList[Random.Range(0, myList.Count)];
                //選んだオブジェクトをuseListに追加
                useList.Add(randomPin);
                //選んだオブジェクトのリスト番号を取得
                choiceNum = myList.IndexOf(randomPin);
                //同じリスト番号をmyListから削除
                myList.RemoveAt(choiceNum);

            }

            Rigidbody rb0 = useList[0].transform.GetComponent<Rigidbody>();
            rb0.mass = 300;

            Rigidbody rb1 = useList[1].transform.GetComponent<Rigidbody>();
            rb1.mass = 300;

            Rigidbody rb2 = useList[2].transform.GetComponent<Rigidbody>();
            rb2.mass = 300;

            Rigidbody rb3 = useList[3].transform.GetComponent<Rigidbody>();
            rb3.mass = 300;

            Rigidbody rb4 = useList[4].transform.GetComponent<Rigidbody>();
            rb4.mass = 300;

            Rigidbody rb5 = useList[5].transform.GetComponent<Rigidbody>();
            rb5.mass = 300;

            Rigidbody rb6 = useList[6].transform.GetComponent<Rigidbody>();
            rb6.mass = 300;

        }
    }

     
    
}
