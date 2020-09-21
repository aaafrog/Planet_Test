using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagManager : MonoBehaviour
{
    // Dictionaryの宣言
    public Dictionary<string, int> itemFlags = new Dictionary<string, int>();

    /*  初期値を持たせる場合の書き方
    // Dictionaryの宣言と初期値の設定
    public Dictionary<string, int> itemFlags = new Dictionary<string, int>() {
        {"key0", 0},
        {"key1", 0}
    };
    */

    /*
     * 別のscriptで使用する方法
     * 呼び出し側のscriptと、このscriptを同一のオブジェクトにアタッチし、
     * 以下のコードを記述
     * private FlagManager flagManager;    // FlagManagerを入れる変数、class直下に記述
     * flagManager = GetComponent<FlagManager>();    // FlagManagerを取得、startメソッド内に記述
     * 
     * 以下は必要な個所へ
     * flagManager.itemFlags.Add("key2", 0);    // FlagManagerのDictionary「itemFlags」に値を追加
     * flagManager.itemFlags["key2"] = 222;    // FlagManagerのDictionary「itemFlags」の任意の値を変更
     * Debug.Log(flagManager.itemFlags["key2"]);    // FlagManagerのDictionary「itemFlags」の任意の値をDebug.Log表示
     * 
     * // キーと要素の列挙
     * foreach (KeyValuePair<string, int> pair in flagManager.itemFlags) {
     * Debug.Log (pair.Key + " : " + pair.Value);
     * }
            
        どこからでも追加変更が可能なようなので、ここをいじる必要はなさそうです。
        完成時にキーと要素をまとめて、値クリアのメソッドに追加するくらいで良いと思われ。
        値クリアはゲームクリア時に使う？
         
    */



    // itemFlagsをクリアする、呼び出す際はflagManager.ItemFlagsClear();と記述
    public void ItemFlagsClear()
    {
        itemFlags = new Dictionary<string, int>
        {
            {"key0",0},
            {"key1",0},
            {"key2",0},
        };
    }


    // Start is called before the first frame update
    void Start()
    {
        /*  動作テスト
        itemFlags.Add("key2", 0);    // 追加
        itemFlags["key2"] = 222;    // value変更
        Debug.Log(itemFlags["key2"]);    // 表示
        */
    }

    // Update is called once per frame
    void Update()
    {

    }
}
