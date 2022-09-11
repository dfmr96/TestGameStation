using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSetup : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 speedVector = new Vector3(Random.Range(-5, 5), Random.Range(5, 8), Random.Range(8, 12));
        rb.MovePosition(transform.position + speedVector * Time.fixedDeltaTime);
    }   
}
