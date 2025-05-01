using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 initialPosition;
    private Rigidbody rb;
    
    
    void Start()
    {
        initialPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }
    
    public void BallSetUp()
    {
        transform.position = initialPosition;
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    public void respawn(GameObject gameObject)
    {
        transform.position = gameObject.transform.position;
    }
}
