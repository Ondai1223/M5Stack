using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TitleManager : MonoBehaviour
{
   [SerializeField] TitleMenu menu;
    protected int num;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(num < 2)
            {
                num++;
            }
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(num > 0)
            {
                num--;
            }
        }

        menu.selectText(num);

        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(num == 0)
            {
                //ゲームシーンに遷移する
                SceneManager.LoadScene("GameScene");
            }

            if(num == 1)
            {
                //設定画面表示
            }

            if(num == 2)
            {
                //ゲームを終了する
                #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
                #else
                    Application.Quit();//ゲームプレイ終了
                #endif
            }
        }
        
    }
}
