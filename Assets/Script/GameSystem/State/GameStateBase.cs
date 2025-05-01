using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateBase  //MonoBehaviourを継承しない=>Unityの性質を使えない
{
    //誰の状態を管理するのかを決める
    protected GameSystem Owner;

    //コンストラクタ
    public GameStateBase(GameSystem owner)
    {
        Owner = owner;
    }

    // その状態に入った時に呼ばれる
    public virtual void OnEnter()
    {

    }
    
    // その状態のマイフレーム更新
    public virtual void OnUpdate()
    {

    }

    // その状態を出る時に呼ばれる
    public virtual void OnExit()
    {
        
    }
}
