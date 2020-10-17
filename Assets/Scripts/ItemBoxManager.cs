using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxManager : MonoBehaviour
{    
    //インスタンス用
    public static ItemBoxManager instance;
    private void Awake()
    {
        instance = this;
    }
    //アイテムボックス
    public GameObject[] ItemBoxs;

    public void SetItem(ItemManager.Item item)
    {
        int index = (int)item;
        ItemBoxs[index].SetActive(true);
    }

    public bool CanUseItem(ItemManager.Item item)
    {
        int index = (int)item;
        return ItemBoxs[index].activeSelf;
    }

    public void UseItem()
    {

    }

}
