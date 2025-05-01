using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] GameObject TitlePanel;
    [SerializeField] GameObject ResultPanel;
    [SerializeField] Color highlightColor;
    //Titleのtext
    [SerializeField] TextMeshProUGUI StartText;
    [SerializeField] TextMeshProUGUI SettingsText;
    [SerializeField] TextMeshProUGUI ExitText;
    //カウントダウンText
    [SerializeField] TextMeshProUGUI CountText;
    private bool complete = false;
    //Resultのtext
    [SerializeField] TextMeshProUGUI MenuText;
    [SerializeField] TextMeshProUGUI RestartText;
    
    
    public void TitleSelectText(int selectNum)
    {

        if(selectNum == 0)
        {
            StartText.color = highlightColor;
            SettingsText.color = Color.white;
            ExitText.color = Color.white;
        }if(selectNum == 1)
        {
            SettingsText.color = highlightColor;
            StartText.color = Color.white;
            ExitText.color = Color.white;
        }if(selectNum == 2)
        {
            ExitText.color = highlightColor;
            SettingsText.color = Color.white;
            StartText.color = Color.white;
        }
        
    }

    public void ResultSelectText(int selectNum)
    {

        if(selectNum == 0)
        {
            MenuText.color = highlightColor;
            RestartText.color = Color.white;
        }
        
        if(selectNum == 1)
        {
            RestartText.color = highlightColor;
            MenuText.color = Color.white;
            
        }
        
        //if(selectNum == 2)
        // {
            
        // }
        
    }

    //タイトルパネルの表示非表示をする関数
    public void EnableTitlePanel(bool enabled)
    {
        TitlePanel.SetActive(enabled);
    }

    //リザルトパネルの表示非表示をする関数
    public void EnableResultPanel(bool enabled)
    {
        ResultPanel.SetActive(enabled);
    }

    public bool Comp{get => complete; set => complete = value;}

    public void Count()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(0.5f);
        CountText.text = "３";
        yield return new WaitForSeconds(1);
        CountText.text = "２";
        yield return new WaitForSeconds(1);
        CountText.text = "１";
        yield return new WaitForSeconds(1);
        CountText.text = "すたあと";
        yield return new WaitForSeconds(1);
        CountText.text = " ";
        complete = true;
    }

}
