using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSetup : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Random.Range(-5,5), Random.Range(5,8), Random.Range(8,12));
    }
}
