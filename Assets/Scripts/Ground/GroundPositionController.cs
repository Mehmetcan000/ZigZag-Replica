using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{

    private GroundSpawnController spawnController;

    private Rigidbody rb;

    [SerializeField]
    private float endYValue;

    private int groundDirection;

     
    void Start()
    {
       spawnController = FindObjectOfType<GroundSpawnController>();
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        CheckGroundVerticalPosition();
    }

    private void CheckGroundVerticalPosition()
    {
        if (transform.position.y <= endYValue)
        {
            SetRigidBodyValues();

            groundDirection = Random.Range(0, 2);

            if (groundDirection == 0)
            {
                transform.position = new Vector3(spawnController.lastGroundObject.transform.position.x - 1f, spawnController.lastGroundObject.transform.position.y,
                    spawnController.lastGroundObject.transform.position.z);
            }
            else
            {
                transform.position = new Vector3(spawnController.lastGroundObject.transform.position.x, spawnController.lastGroundObject.transform.position.y,
                    spawnController.lastGroundObject.transform.position.z+1f);
            }
            spawnController.lastGroundObject = gameObject;
        }
    }
    private void SetRigidBodyValues()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
