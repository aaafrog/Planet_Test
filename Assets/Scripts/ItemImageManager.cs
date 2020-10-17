using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemImageManager : MonoBehaviour
{    //インスタンス化
    public static ItemImageManager instance;
    private void Awake()
    {
        instance = this;
    }

    public GameObject ItemImageBg;

    public GameObject[] ItemImage;

    public void ItemImageClose()
    {
        ItemImageBg.SetActive(false);

        for (int i = 0; i < ItemImage.Length; i++)
        {
            ItemImage[i].SetActive(false);
        }
    }
}
