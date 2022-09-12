using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform ballTransform;

    private Vector3 offSet;
    private Vector3 newPosition;

    [SerializeField]
    [Range(0,3)]
    private float lerpValue;


    void Start()
    {
        offSet = transform.position - ballTransform.position;
    }


    private void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, ballTransform.position + offSet, lerpValue * Time.deltaTime);
        transform.position = newPosition;   
    }
}
