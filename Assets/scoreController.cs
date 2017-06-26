using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class scoreController : MonoBehaviour {
      //GameObject gameObject
      //大文字の型の小文字の変数をもっている。
    private GameObject scoreUIObject;
      //省略できる。
    private Text scoreText;
    //Text型のscoreText変数。目的は、Text型の文字列を表示させる為に使用。（hogeでもok）   GameObject名のscoreTextと名前は一緒だが、意味が違う。勘違い注意!!
    private int score;
    //int型のscore変数。目的は、scoreを計算する為に使用。 20+10+・・・・等の計算に使用する。


   // Use this for initialization
    void Start () {
      scoreUIObject = GameObject.Find("scoreText");
      scoreText = scoreUIObject.GetComponent<Text>();
      //Text型のscoreText変数は、（クラスで宣言しているGameObjectの）scoreUIObject の scoreText（一行前のところでGameObject.Findしている)の中にある、<Text>プロパティをGetComponentする　という意味。
      score = 0;
   }
   void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "LargeCloudTag") {
          //gameObjectは、GameObjectとは別もので、MonoBehaviourの機能の一つ。
          //例えば、  Debug.Log(gameObject.name) とすると、MonoBehaviourがくっついているクラス名が表示される。
            score += 20;
        }
        else if(collision.gameObject.tag == "SmallCloudTag") {
            score += 10;
        }
        scoreText.text = score.ToString();
          //Text型のscoreText変数の中のtextプロパティにstring型のscoreを入れる。
        //Text型の変数scoreTextは、int型の得点を表示することができない。そのため、int型の得点を、string型に置換して、Text型の変数に表示させる。Text型の変数に、string型の文字を表示させることはできる。
}
}
