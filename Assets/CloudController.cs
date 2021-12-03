using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//「public → どのクラスでも使える」　　　↓Unityが提供する機能を継承する宣言（例／ Start とか Update とか）
public class CloudController : MonoBehaviour
{
    //↓拡大縮小に関する変数を宣言。「pribate → ここ以外のクラスで使えない」

    //最小サイズ
    private float minimum = 1.0f;
    //拡大縮小スピード
    private float magSpeed = 10.0f;
    //拡大率
    private float magnification = 0.07f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //雲を拡大縮小
        　//↓「transform」とは、オブジェクトの位置と回転とサイズを保持しているクラス。
        　　　　　　　　　　　　　　　　　//↓「Vector」は、オブジェクトの「座標」やオブジェクトに「加わる力の方向」などを扱う型（newは生成するという意味）
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
    }
}
