using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputController : MonoBehaviour
{
    public Vector3 ballDirection;

    void Start()
    {
        ballDirection = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        HandleBallInput();
        
    }

    private void HandleBallInput()
    {
        if (Input.GetMouseButtonDown(0)) //Farenin her sol clickine basýldýgýnda top hareket edecek.
        {
            ChangeBallDirection();
        }

    }

    private void ChangeBallDirection()
    {
        if (ballDirection.x == -1 ) //Top Sola Doðru hareket ediyorsa.
        {
            ballDirection = Vector3.forward;
        }
        else
        {
            ballDirection = Vector3.left;
        }

    }
}
