using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;　//これを加える事でUnityのUI機能を使う事ができる。

public class Tokuten : MonoBehaviour
{
    //得点
    private int tokuten = 0;

    //得点の変数「tokutenText」を宣言
    private GameObject tokutenText;

    //衝突したタイミングで加算。
    void Score(int ten)　　//tokuten変数に足して行くスクリプト（引数でten変数を受け取り+=で加算）
    {
        //得点を「tokuten」に合計していく
        this.tokuten += ten;
        //tokutenの合計値を表示
        this.tokutenText.GetComponent<Text>().text = "SCORE "+ tokuten;
    }


    void Start()
    {
        //「TokutenText」を変数に代入し取得（取得はスタートでやっとくっぽい）
        this.tokutenText = GameObject.Find("TokutenText");
    }


    void Update()
    {

    }

    //↓衝突時に呼ばれる関数（自分のColliderが他のオブジェクトのColliderと接触した時に呼ばれる）
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")　　　　　　　　　// == → 左辺と右辺が等しい場合にtrue
        {
            Score(10);　　　//10点加算（10点をten変数に代入）
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            Score(20);　　　//20点加算（20点をten変数に代入）
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            Score(30);　　　　//30点加算（30点をten変数に代入）
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            Score(40);　　　　//40点加算（40点をten変数に代入）
        }
    }
}
