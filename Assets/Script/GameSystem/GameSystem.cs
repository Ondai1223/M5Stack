using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameSystem : MonoBehaviour
{
    // ゲーム進行の状態管理(画面遷移)
    // ・タイトル(プレイ状態のみ遷移する)
    // ・プレイ(タイトル状態、リザルト状態どちらにも遷移する)
    // ・リザルト(タイトル状態、プレイ状態に遷移する)

    private GameStateBase currentState;
    private TitleState titleState;
    private PlayState playState;
    private ResultState resultState;
    [SerializeField] GameUIManager gameUIManager;

    public TitleState TitleSt {get => titleState;}
    public PlayState PlaySt {get => playState;}
    public ResultState ResultSt {get => resultState;}
    public GameUIManager UIManager {get  => gameUIManager;}
    void Start()
    {
        titleState = new TitleState(this);
        playState = new PlayState(this);
        resultState = new ResultState(this);

        ChangeState(titleState);

    }

    public void ChangeState(GameStateBase newState)
    {
        currentState = newState;
        currentState.OnEnter();
    }

    
   
    private float currentTime = 0f;
    [SerializeField] Goal Goal;
    [SerializeField] GameObject Spawn;
    [SerializeField] Player player;
    [SerializeField] PlayerController playerController;
    [SerializeField] TextMeshProUGUI currentTimeText;
    [SerializeField] TextMeshProUGUI resultTimeText;
    [SerializeField] TextMeshProUGUI bestTimeText;


    public Goal goal{get => Goal;}
    public GameObject respawn{get => Spawn;}
    public float ClearTime{get => currentTime; set => currentTime = value;}
    public Player Ball{get => player;}
    public PlayerController Stage{get => playerController;}
    public TextMeshProUGUI ClearTimeText{get => currentTimeText;}
    public TextMeshProUGUI ResultTimeText{get => resultTimeText;}
    public TextMeshProUGUI BestTimeText{get => bestTimeText;}
    
    void Update()
    {
        currentState.OnUpdate();
        
    }

    // リザルト状態の処理
    // public void Restart()
    // {
    //     resultPanel.SetActive(false);
    //     currentTime = 0;
    //     isClear = false;
    //     Goal.checkGoal = false;
    //     //球の位置をリセット
    //     Player.reStart(Spawn.spwX, Spawn.spwY);
    //     Debug.Log("スポーン地点"+ Spawn.spwX + ", " + Spawn.spwY);
    // }
    // リザルト状態の処理
    // public void ReturnMenu()
    // {
    //     titlePanel.SetActive(true);
    // }
}
