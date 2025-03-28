using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float rotatableRigion = 90;
    [SerializeField] bool isReverced;

    [SerializeField] AccelarationDataReceiver receiver;
    private float currentAngle;
    private float angleVelocity; 
    float smoothTime = 0.1f; 
    
	//--------------------------------------------------

	private void Awake()
	{
        // 反転させる場合、-1をかける
        if (isReverced) {
            rotatableRigion *= -1;
        }
	}

	// 移動
	void FixedUpdate()
    {
        // var euler = receiver.Accelaration * rotatableRigion;
        float targetAngle = receiver.Accelaration.y * rotatableRigion;
        float changeAngle = receiver.Accelaration.x;
        if(changeAngle < 0.0f)
        {
            targetAngle = ((1 - receiver.Accelaration.y) + 1) * rotatableRigion;
        }
        
        
        //Debug.Log(changeAngle);
        // 滑らかに回転角度を変化させる
        currentAngle = Mathf.SmoothDampAngle(currentAngle, targetAngle, ref angleVelocity, smoothTime);

        transform.rotation = Quaternion.Euler(0, 0, currentAngle);

    }

}
