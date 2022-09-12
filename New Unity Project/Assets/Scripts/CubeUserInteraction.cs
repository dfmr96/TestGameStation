using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeUserInteraction : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    public void InstantiateObject()
    {
        Instantiate(prefab);
    }
}
