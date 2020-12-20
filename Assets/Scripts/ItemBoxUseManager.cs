using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxUseManager : MonoBehaviour
{

    //アイテムボックス
    public enum Itembox
    {
        itembox0,
        itembox1,
        itembox2,
        itembox3,
        itembox4,
        itembox5,
        itembox6,
        itembox7,
    }
    public Itembox itembox;


    public void OnBoxItem()
    {
        //BOX内のアイテムが選択された場合
        int index = (int)itembox;

        int itemFlg = FlagManager.Instance.ItemFlags[index];

        if (itemFlg == 1)
        {

            FlagManager.Instance.ItemFlags[index] = 2;
            Debug.Log("フラグは" + itemFlg);
        }
        else if (itemFlg == 2)
        {
            FlagManager.Instance.ItemFlags[index] = 1;
            Debug.Log("フラグは" + itemFlg);
        }

    }
}
