using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject Planet;
    public GameObject Title;

    public void OnGamestart()
    {
        SceneManager.LoadScene("SceneOpening");
    }

    public void PlanetMotion(int x,int y,int z) {
        Planet.transform.Rotate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
    }
    public void TitleMotion()
    {
    }

    private void Update()
    {
        PlanetMotion(0,0,20);
    }
}
