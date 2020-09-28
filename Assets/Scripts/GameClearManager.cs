using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン遷移を扱う

public class GameClearManager : MonoBehaviour
{
    //StageSelect画面へ
    public void GoToStageSelect()
    {
        Debug.Log("StageSelect画面に遷移");
        SceneManager.LoadScene("StageSelect");
    }
}
