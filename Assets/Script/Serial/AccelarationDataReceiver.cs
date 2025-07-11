using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelarationDataReceiver : DataReceiver_Base
{
    /// <summary>
	/// デバイスの加速度
	/// </summary>
	public Vector2 Accelaration { get; private set; }       
    //reverseTrigger=
    public float reverseTrigger { get; private set; }
    private static AccelarationDataReceiver instance;
    //--------------------------------------------------

/**
    private void Awake()
    {
        ///ここから///
		if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject); 
		///ここまで///
    }
    */
    // 受信
    protected override void OnReceivedData()
    {
        var data = handler.GetSplitedData();     // データ取得
        
        try {
            if (data.Length >= 2) {
                // データ文字列からfloat型に変換して、ベクトルに適用

                float x = float.Parse(data[0]);
                float y = float.Parse(data[1]);
                Debug.Log("Received Data: " + x + "," + y);
                Accelaration = new Vector2(x, y);
            }
        }

        // 例外
        catch (System.Exception exc) {
            Debug.LogWarning(exc.Message);
        }
    }
}
