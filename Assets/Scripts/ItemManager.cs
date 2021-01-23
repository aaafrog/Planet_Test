using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemManager : MonoBehaviour
{

    public GameObject Message_Panel;

    //*******************************************************************
    //                表示するメッセージ
    //*******************************************************************
    public CommonManager commonManager;

    // 書くスピード(短いほど早い)
    public float writeSpeed = 0.2f;

    // テキストを書くメソッド
    public void Write(string s)
    {
        //毎回、書くスピードを 0.2 に戻す------<戻したくない場合はここを消す>
        writeSpeed = 0.2f;

        StartCoroutine(IEWrite(s));
    }

    // 書くためのコルーチン
    IEnumerator IEWrite(string s)
    {
        //書いている途中の状態にする
        //isWriting = true;

        //渡されたstringの文字の数だけループ
        for (int index = 0; index < s.Length; index++)
        {
            //テキストにi番目の文字を付け足して表示する
            //text.text += s.Substring(index, 1);
            //次の文字を表示するまで少し待つ
            yield return new WaitForSeconds(writeSpeed);
        }
        //書いている途中の状態を解除する
        //isWriting = false;
    }

    //インスタンス化
    public static ItemManager instance;
    private void Awake()
    {
        instance = this;
    }

    //アイテム
    public enum Item
    {
        item0,  // 塩
        item1,  // 大豆
        item2,  // 麹菌
        item3,  // 納豆菌
        item4,  // 味噌
        item5,  // 味噌汁
        item6,  // アラ汁
        item7,  // 魚の骨
        item9999 = 9999,  // 欠番
    }
    public Item item;

    public void Start()
    {
        //アイテム判定
        ItemFlgCheck();
    }

    //アイテムフラグチェック
    public void ItemFlgCheck()
    {
        int index = (int)item;

        if (FlagManager.Instance.ItemFlags[index] == 1)
        {
            //フラグが1の場合：アイテムボックスに格納、アイテム非表示
            gameObject.SetActive(false);
            ItemBoxManager.instance.SetItem(item);

        } else
        {
            //処理継続
        }
    }

    //アイテムメッセージ表示
    public void ItemMessage()
    {
        Debug.Log("AAA");
        int index = (int)item + 8;
        Debug.Log(index);
        Debug.Log(commonManager.testtext);
        //Write(commonManager.Scenarios[index][1]);

    }


    //アイテムクリック時
    public void OnGetItem()
    {
        int index = (int)item;

        ItemBoxManager.instance.SetItem(item);

        // 取ったら消えるアイテムだけ消す
        if (index != 0 && index != 1 && index != 5 && index != 6)
        {
            gameObject.SetActive(false);
        }
        
        Debug.Log(item + "を取得");

        FlagManager.Instance.ItemFlags[index] = 1;
        Debug.Log(FlagManager.Instance.ItemFlags[index]);

        //ItemImage表示
        ItemImageManager.instance.ItemImageBg.SetActive(true);
        ItemImageManager.instance.ItemImage[index].SetActive(true);

        //メッセージパネルアクティブ
        //Message_Panel.SetActive(true);

        //ItemImage表示
        ItemMessage();
        ItemImageManager.instance.ItemImageBg.SetActive(true);
        ItemImageManager.instance.ItemImage[index].SetActive(true);

    }






    //アイテム入手時の表示
    //でかいアイテム画像＋アイテムメッセージ
    //クリックしたらでかいアイテム画像＋メッセージを消す



    //デバック用
    public void Scenemove_Title()
    {
        SceneManager.LoadScene("SceneTitle");
    }
    public void Scenemove_Stage0()
    {
        SceneManager.LoadScene("SceneStage0");
    }
    public void Scenemove_Stage1()
    {
        SceneManager.LoadScene("SceneStage1");
    }
    public void Scenemove_Stage2()
    {
        SceneManager.LoadScene("SceneStage2");
    }
    public void Scenemove_Stage3()
    {
        SceneManager.LoadScene("SceneStage3");
    }


    //アイテムゲット方法
    //１．アイテムにItemManager.csを張り付け
    //２．Itemで入手したいアイテムを選択（魚の骨ならItem7）
    //３．ほかの処理を追加した場合は後続に追記
    //４．ボタンに自身のオブジェクトを張り付け
    //５．自身のメソッドを指定
    public void ActionTest1()
    {
        OnGetItem();
        Debug.Log("魚の骨を手に入れた！");
    }

}
