using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameSystem : MonoBehaviour
{
    private float currentTime = 0f;
    [SerializeField] Goal checkGoal;
    [SerializeField] TextMeshProUGUI currentTimeText;

    void Update()
    {
        // タイマーの更新
        if (checkGoal)
        {
            currentTime += Time.deltaTime;
            currentTimeText.text = "タイム： " + currentTime.ToString("F2") + "s";
        }

    }


}
