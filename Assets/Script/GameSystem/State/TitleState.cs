using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleState : GameStateBase
{
    private int num;
    public TitleState(GameSystem gameSystem) : base(gameSystem)
    {
        
    }
   
    public override void OnEnter()
    {
        Debug.Log("タイトルのOnEnter()");
    }

    public override void OnUpdate()
    {

        Debug.Log("タイトルのOnUpdate()");
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

        Owner.UIManager.TitleSelectText(num);

        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(num == 0)
            {
                //ゲームシーンに遷移する(TitlePanelを非表示にする.)
                Owner.UIManager.EnableTitlePanel(false);
                Owner.ChangeState(Owner.PlaySt);
                
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
