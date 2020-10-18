using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CommonManager : MonoBehaviour
{
    //ゲームに共通するスクリプト
    //・タイトルへ戻るボタン
    //・メッセージ（メッセージウィンドウ）

    //外部CSVをListに格納する
    TextAsset csvFile;  // CSVファイル
    public List<string[]> Scenarios = new List<string[]>();


    void Start()
    {
        // CSVを読み込み、一行ずつListに追加する
        csvFile = Resources.Load("Message") as TextAsset; // Resouces下のCSV読み込み
        StringReader reader = new StringReader(csvFile.text);

        // リストに追加していく
        while (reader.Peek() != -1) // reader.Peaekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            Scenarios.Add(line.Split(',')); // , 区切りでリストに追加
        }

        // Scenarios[行][列]を指定して値を自由に取り出せる
        Debug.Log(Scenarios[0][0]);
        Debug.Log("<color=red>(・∀・)ｲｲ!!</color>");
        

    }
    public string testtext = "あああ";


}
