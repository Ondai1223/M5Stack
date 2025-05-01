using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultState : GameStateBase
{
    
    private float bestTime = 1000.0f;
    private float clearTime = 0f;
    private int num;
    public ResultState(GameSystem gameSystem) : base(gameSystem)
    {

    }

    public override void OnEnter()
    {
        Debug.Log("リザルトのOnEnter()");
        num = 0;
        clearTime = Owner.ClearTime;
        Owner.UIManager.EnableResultPanel(true);

        Owner.ResultTimeText.text = Owner.ClearTimeText.text;
        //ベストタイム更新
        if(clearTime < bestTime)
        {
            bestTime = clearTime;
            Owner.BestTimeText.text = "ベストタイム：" + bestTime.ToString("F2") + "s";
        }else{
            Owner.BestTimeText.text = "ベストタイム：" + bestTime.ToString("F2") + "s";
        }
        
    }

    public override void OnUpdate()
    {
        
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(num < 1)
            {
                num++;
            }
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(num > 0)
            {
                num--;
            }
        }

        Owner.UIManager.ResultSelectText(num);

        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(num == 0)
            {
                //タイトルに戻る
                Owner.UIManager.EnableTitlePanel(true);
                Owner.UIManager.EnableResultPanel(false);
                Owner.ChangeState(Owner.TitleSt);
                
            }

            if(num == 1)
            {
                //リスタート
                Owner.UIManager.EnableResultPanel(false);
                Owner.ChangeState(Owner.PlaySt);
            }

            // if(num == 2)
            // {
            //    
            // }
        }
            
        
    }
}
