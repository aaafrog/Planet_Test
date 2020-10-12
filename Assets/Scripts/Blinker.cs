using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// オブジェクトを点滅させるクラス
public class Blinker : MonoBehaviour
{
    // 点滅の時間・色を変更する場合はここを変更
    private static float FADE_TIME = 10.0f;   // フェードしたい時間を指定
    private static float COLOR_R_MAX = 0.1f;    // RGBのR値の最大値を指定
    private static float COLOR_G_MAX = 0.2f;    // RGBのG値の最大値を指定
    private static float COLOR_B_MAX = 0.3f;    // RGBのB値の最大値を指定
    // 点滅の時間・色を変更する場合はここを変更


    private MeshRenderer r;    // MeshRendererコンポーネント取得用

    private static float colorChange = 0.0f;    // 時間による変更度
    private Color emissionColor = new Color(0.0f, 0.0f, 0.0f, 1.0f);    // 色指定用
    private static float colorR = 0.0f;    // RGBのR値格納用
    private static float colorG = 0.0f;    // RGBのG値格納用
    private static float colorB = 0.0f;    // RGBのB値格納用

    private bool changeFlag = false;    // 変更完了フラグ

    void Start()
    {
        // マテリアルの変更するパラメータを事前に知らせる
        r = GetComponent<MeshRenderer>();        
        r.material.EnableKeyword("_EMISSION");
    }

    void Update()
    {

        if (changeFlag == false)
        {
            colorChange += Time.deltaTime / FADE_TIME;    // フレーム間で経過した時間をフェードしたい時間で割り、時間経過の割合を出して、colorChangeに加算？
            ChangeColor();

            if (colorChange >= 1.0f)
            {
                colorChange = 1.0f;
                changeFlag = true;
            }
        }
        else if (changeFlag == true)
        {
            colorChange -= Time.deltaTime / FADE_TIME;
            ChangeColor();

            if (colorChange <= 0.0f)
            {
                colorChange = 0.0f;
                changeFlag = false;
            }
        }
    }

    void ChangeColor()  // 時間経過を受け取り色を変更する
    {
        colorR = COLOR_R_MAX * colorChange;    // R値の最大値に時間経過をかけて、R値の最大値までの割合を出す
        colorG = COLOR_G_MAX * colorChange;    // G値の最大値に時間経過をかけて、G値の最大値までの割合を出す
        colorB = COLOR_B_MAX * colorChange;    // B値の最大値に時間経過をかけて、B値の最大値までの割合を出す

        Color emissionColor = new Color(colorR, colorG, colorB, 1.0f);    // RGB値の最大値までの割合を格納したColor
        r.material.SetColor("_EmissionColor", emissionColor);    // マテリアルのEmissionColorに色をColorを渡す
        //Debug.Log(colorChange);
    }

}