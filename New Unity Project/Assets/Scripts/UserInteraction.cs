using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInteraction : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    public void InstantiateObject()
    {
        Instantiate(prefab);
    }
}
