using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class OpeningManager : MonoBehaviour
{
    //*******************************************************************
    //                Unityで設定
    //*******************************************************************

    /// メッセージパネル（ボタン）
    public GameObject MessagePanel;

    /// テキスト
    public Text text;

    //*******************************************************************
    //                情報と基本メソッド
    //*******************************************************************

    /// 書くスピード(短いほど早い)
    public float writeSpeed = 0.2f;

    /// 書いている途中かどうか
    public bool isWriting = false;

    /// 文章の番号は Key で表す
    public int key = 0;

    /// テキストを書くメソッド
    public void Write(string s)
    {
        //毎回、書くスピードを 0.2 に戻す------<戻したくない場合はここを消す>
        writeSpeed = 0.2f;

        StartCoroutine(IEWrite(s));
    }

    /// テキストを消すメソッド
    public void Clean()
    {
        text.text = "";
    }

    //*******************************************************************
    //                表示するメッセージ
    //*******************************************************************
    public CommonManager commonManager;
    static Dictionary<int, string> message = new Dictionary<int, string>()
    { 
        //----\nは改行を表す----
        { 1, "おはようございます、これは1番目のメッセージです" },
        { 2, "\nこんにちは、これは2番目のメッセージです" },
        { 3, "こんばんは、これは3番目のメッセージです" },
        { 4, "\nおやすみなさい、これは4番目のメッセージです" },
        { 999, "\nこれでメッセージの表示を終わります" },
    };

    //*******************************************************************
    //                メッセージパネルがタッチされた時の処理
    //*******************************************************************
    int i = -1;
    public void Start()
    {
        i++;
        Clean();
        Write(commonManager.Scenarios[i][1]);
        Debug.Log("デフォルト");
    }

    //このメソッドが呼ばれる
    public void OnClick()
    {
       //i++;
        //Debug.Log(i);
        //string aaa = commonManager.testtext;
        //Debug.Log(commonManager.Scenarios[0][1]);
        //前のメッセージを書いている途中かどうかで分ける
        Debug.Log("CCC");
        if (i <= 2)
        {
            if (isWriting)
            {
                //書いている途中にタッチされた時------------------------------

                //スピード(かかる時間)を 0 にして、すぐに最後まで書く
                writeSpeed = 0f;
                Debug.Log("全表示");

            }
            else
            {
                Clean();
                Write(commonManager.Scenarios[i][1]);
                Debug.Log("書く");              
            }
        }
        else {
            //メッセージパネルを消す
            Debug.Log("メッセージパネルを消す");
            MessagePanel.SetActive(false);
        }
        //i++;
    }

    //*******************************************************************
    //                その他
    //*******************************************************************

    /// 書くためのコルーチン
    IEnumerator IEWrite(string s)
    {
        //書いている途中の状態にする
        isWriting = true;
        //渡されたstringの文字の数だけループ
        for (int i = 0; i < s.Length; i++)
        {
            //テキストにi番目の文字を付け足して表示する
            text.text += s.Substring(i, 1);
            //次の文字を表示するまで少し待つ
            yield return new WaitForSeconds(writeSpeed);
        }
        //書いている途中の状態を解除する
        isWriting = false;
    }

    /// ゲームスタート時の処理
    // void Start()
    //{
    //メッセージパネルに書かれている文字を消す
    //Clean();
    //}
}
