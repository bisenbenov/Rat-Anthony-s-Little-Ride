using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatRoadController : MonoBehaviour
{
    public static RatRoadController instance;

    [HideInInspector] public float speed = 0f;
    private float inertionSpeed;

    [HideInInspector] public bool wPressed = false;
    [HideInInspector] public bool sPressed = false;

    private void Awake()
    {
        instance = this;
    }

    void PressS()
    {
        sPressed = true;
        speed /= 1.01f;
    }

    void PressW()
    {
        wPressed = true;
        speed += 0.09f;
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {   
            PressW();
            
            if (speed > 100f)
            {
                speed = 100f;
            }            
        }
        
        if (wPressed && (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
        {
            PressS();

            if (speed < 5f)
            {
                speed = 0f;
                inertionSpeed = 0f;
            }
        }

        inertionSpeed = speed / 1.1f;
        transform.position += transform.forward * inertionSpeed * Time.deltaTime;
    }
}
