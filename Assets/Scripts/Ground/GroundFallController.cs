using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFallController : MonoBehaviour
{

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 

    }
    
    public IEnumerator SetRigidBodyValue()
    {
        yield return new WaitForSeconds(.75f);
        rb.useGravity = true;
        rb.isKinematic = false;
    }
}
