using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingJointコンポーネントを入れる（インスペクタに追加したやつ）
    private HingeJoint myHingeJoint;　//HingeJoint型のメンバ変数（HingeJointを代入する為、同じクラスの変数を宣言）

    //初期の傾き
    private float defaultAngle = 20;

    //弾いた時の傾き
    private float flickAngle = -20;


    
    void Start()
    {
        //HingeJointコンポーネント取得　（上記で宣言した変数に、HingeJointを取得して代入）
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定（呼び出し元）
        SetAngle(this.defaultAngle);　　//自作のSetAngle関数（最下記）を呼び出している
    }

    
    void Update()
    {
        //左矢印キーを押した時、左フリッパーを動かす　　 ↓&&（左右の条件式が両方trueであればtrue）==（左辺と右辺が等しい場合にtrue）
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);　//SetAngle関数を呼び出している
        }
        //右矢印キーを押した時、右フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);　//SetAngle関数を呼び出している
        }

        //矢印キーが離された時、フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);　//SetAngle関数を呼び出している
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);　//SetAngle関数を呼び出している
        }

    }

    //フリッパーの傾きを設定（呼び出される側）
    public void SetAngle (float angle)　　　//void型のSetAngle関数を自作
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;　　　　　　　　　　//angleに引数defaultAngleが代入される
        this.myHingeJoint.spring = jointSpr;
    }
}
