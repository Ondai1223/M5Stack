using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayState : GameStateBase
{
   
     public PlayState(GameSystem gameSystem) : base(gameSystem)
    {

    }

    public override void OnEnter()
    {
        Debug.Log("プレイのOnEnter()");
        //ゲームプレイ中ようのサウンドを再生
        SoundManager.Instance.PlayBGM(BGMSoundData.BGM.GamePlay);
        //ステージ,ボール,タイム,ゴール判定の初期化処理.それぞれのクラスからメソッドを実行
        Owner.Ball.BallSetUp();
        Owner.Stage.StageSetUp();
        Owner.ClearTime = 0f;
        Owner.goal.checkGoal = false;
        //初期位置を設定できたらカウントダウンをする.
        Owner.UIManager.Count();
        
    }

    public override void OnUpdate()
    {
        if(Owner.UIManager.Comp)
        {
        //プレイ中の処理
        // タイマーの更新
        //ゴールしていない間タイマーが動いている
        if (!Owner.goal.checkGoal)
        {
            Owner.Stage.RotatableUpdate();
            Owner.ClearTime += Time.deltaTime;
            Owner.ClearTimeText.text = "タイム： " + Owner.ClearTime.ToString("F2") + "s";
        }

        //ゴールしたらゴールモーダルを表示するs
        if(Owner.goal.checkGoal )
        {
            Owner.UIManager.Comp = false;
            SoundManager.Instance.PlaySE(SESoundData.SE.Goal);
            Owner.ChangeState(Owner.ResultSt);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Owner.Ball.respawn(Owner.respawn);
        }

        }

    }
}
