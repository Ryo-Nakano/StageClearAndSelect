using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン遷移扱う

public class StageSelectManager : MonoBehaviour
{
    [SerializeField] GameObject stage2_Cover;
    [SerializeField] GameObject stage3_Cover;

    void Start()
    {
        RefreshUI(); //画面表示の更新
    }

    //画面表示の更新
    void RefreshUI() {
        int clearStageNum = PlayerPrefs.GetInt("ClearStage");

        //一度全部のカバーをかける
        stage2_Cover.SetActive(true); //カバーつける
        stage3_Cover.SetActive(true); //カバーつける

        //clearStageNumの値に応じてカバーを外す
        switch (clearStageNum) 
        { 
            case 0: //ステージ未クリア
                Debug.Log("まだ1つもクリアしていない");
                break;

            case 1: //1ステージクリア
                Debug.Log("Stage1までクリアている");
                stage2_Cover.SetActive(false); //カバーを外す
                break;

            case 2: //2ステージクリア
                Debug.Log("Stage2までクリアている");
                stage2_Cover.SetActive(false); //カバーを外す
                stage3_Cover.SetActive(false); //カバーを外す
                break;

            case 3:
                Debug.Log("Stage3までクリアている");
                stage2_Cover.SetActive(false); //カバーを外す
                stage3_Cover.SetActive(false); //カバーを外す
                break;
        }
    }

    //Stage1ボタン押した時の処理
    public void GoToStage1()
    {
        Debug.Log("Stage1を選択した");
        SceneManager.LoadScene("Stage1");
    }

    //Stage2ボタン押した時の処理
    public void GoToStage2()
    {
        Debug.Log("Stage2を選択した");
        SceneManager.LoadScene("Stage2");
    }

    //Stage3ボタン押した時の処理
    public void GoToStage3()
    {
        Debug.Log("Stage3を選択した");
        SceneManager.LoadScene("Stage3");
    }

    //ゲームのクリア状況を削除する
    public void DeleteClearDataButton()
    {
        Debug.Log("クリアデータを削除した");

        PlayerPrefs.DeleteKey("ClearStage"); //ClearDataの削除
        RefreshUI(); //画面表示の更新
    }
}
