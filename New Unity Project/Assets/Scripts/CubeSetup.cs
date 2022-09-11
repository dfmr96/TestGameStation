using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSetup : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] GameObject spherePrefab;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Random.Range(-5,5), Random.Range(5,8), Random.Range(8,12));
    }

    private void OnDestroy()
    {
        Instantiate(spherePrefab);
    }
}
