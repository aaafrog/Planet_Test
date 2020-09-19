using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CommonManager : MonoBehaviour
{
    //ゲームに共通するスクリプト
    //・タイトルへ戻るボタン
    //・メッセージ（メッセージウィンドウ）

    //タイトルへ戻る
    public void OnTitleBackButton()
    {
        SceneManager.LoadScene("SceneTitle");
    }

}