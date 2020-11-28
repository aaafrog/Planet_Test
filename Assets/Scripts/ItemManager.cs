using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemManager : MonoBehaviour
{

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

    //アイテムクリック時
    public void OnGetItem()
    {
        int index = (int)item;

        ItemBoxManager.instance.SetItem(item);

        if (index != 0 || index != 1 || index != 5 || index != 6)
        {
            gameObject.SetActive(false);
        }
        
        Debug.Log(item + "を取得");

        FlagManager.Instance.ItemFlags[index] = 1;
        Debug.Log(FlagManager.Instance.ItemFlags[index]);

        //ItemImage表示
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
