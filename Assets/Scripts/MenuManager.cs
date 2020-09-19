using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject MenuOFF;
    public GameObject MenuON;

    //
    public void OnMenuButtonOFF()
    {
        MenuON.SetActive(true);
    }

    //
    public void OnMenuButtonON()
    {
        MenuON.SetActive(false);
    }
}
