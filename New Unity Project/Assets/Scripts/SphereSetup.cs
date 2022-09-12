using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSetup : MonoBehaviour
{
    Rigidbody rb;
    Vector3 speedVector;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        speedVector = new Vector3(Random.Range(-5, 5), Random.Range(5, 8), Random.Range(8, 12));
    }
    void Update()
    {
        rb.MovePosition(transform.position + speedVector * Time.fixedDeltaTime);
    }   
}
