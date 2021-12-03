using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;　//これを加える事でUnityのUI機能を使う事ができる。

public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト　（「GameOverText」を代入し、スクリプトで使えるようにする為の変数を宣言）
    private GameObject gameoverText;

    
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得　（スクリプトでTextの表示を変更する為に、上記変数に代入して取得）
        this.gameoverText = GameObject.Find("GameOverText");　//GameObjectクラスの「Find」関数は、引数に与えた文字列の名前のオブジェクトをシーン中から取得
    }

    
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    //↑ボールのz座標this.transform.position.zがvisiblePosZ変数よりも小さい時、ボールが画面外に出たとみなしGameOverを表示
}
