using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;


    void Start(){
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        offset = GetComponent<Transform>().position -target.position;
    }
    void Update()
    {
        GetComponent<Transform>().position = target.position + offset;
    }
}
