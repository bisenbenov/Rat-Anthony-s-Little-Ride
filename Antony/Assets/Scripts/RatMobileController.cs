using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMobileController : MonoBehaviour
{
    RatRoadController roadController;
    private float leftRightTurn = 2.7f;
    private bool cannotTurn;

    private void Start()
    {
        roadController = RatRoadController.instance;
    }

    void PressA()
    {
        transform.position -= transform.right * leftRightTurn * Time.deltaTime;
    }

    void PressD()
    {
        transform.position += transform.right * leftRightTurn * Time.deltaTime;
    }

    void Update()
    {
        cannotTurn = roadController.sPressed && roadController.speed < 10f;

        if (roadController.wPressed && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) && !cannotTurn))
        {
            PressA();
        }

        if (roadController.wPressed && (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) && !cannotTurn))
        {
            PressD();
        }
    }
}
