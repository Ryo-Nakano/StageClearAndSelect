using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン遷移扱う

public class Stage3_Manager : MonoBehaviour
{
    //ゲームクリアしたことにするボタン
    public void GameClear()
    {
        Debug.Log("『ゲームをクリアした！』ことにした");

        PlayerPrefs.SetInt("ClearStage", 3); //ClearStageというタグをつけて、『1』という値を保存
        SceneManager.LoadScene("GameClear");
    }

    //ゲームクリア失敗したことにするボタン
    public void GameOver()
    {
        Debug.Log("『ゲームクリア失敗した...』ことにした");

        SceneManager.LoadScene("GameOver");
    }
}
