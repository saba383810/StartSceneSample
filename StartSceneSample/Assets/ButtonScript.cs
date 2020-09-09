using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ★ここを追加

public class ButtonScript : MonoBehaviour
{
    //クリックされた時に呼ばれるプログラムをpublicで定義
    public void OnClick()
    {
        Debug.Log("Sceneを移動！");
        SceneManager.LoadScene("nextScene");// ★ここを追加
    }
}