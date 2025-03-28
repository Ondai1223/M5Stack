using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TitleMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Color highlightColor;
    [SerializeField] TextMeshProUGUI Title;
    [SerializeField] TextMeshProUGUI StartText;
    [SerializeField] TextMeshProUGUI SettingsText;
    [SerializeField] TextMeshProUGUI ExitText;

    public void selectText(int selectNum)
    {

        if(selectNum == 0)
        {
            StartText.color = highlightColor;
            SettingsText.color = Color.black;
            ExitText.color = Color.black;
        }else if(selectNum == 1)
        {
            SettingsText.color = highlightColor;
            StartText.color = Color.black;
            ExitText.color = Color.black;
        }else if(selectNum == 2)
        {
            ExitText.color = highlightColor;
            SettingsText.color = Color.black;
            StartText.color = Color.black;
        }
        
    }
}
