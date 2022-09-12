using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SphereSpawn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] float timer = 0, sphereCooldown = 0.2f;
    [SerializeField] GameObject prefab, sphereContainer;
    Button button;
    bool isPress = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        isPress = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPress = false;
        foreach (Transform child in sphereContainer.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    private void Start()
    {
        button = GetComponent<Button>();
    }

    
    private void Update()
    {
        if (!isPress)
        {
            timer = 0;
            return;
        }

        timer += Time.deltaTime;


        if (timer > sphereCooldown)
        {
            Instantiate(prefab, sphereContainer.transform);
            timer = 0;
        }
    }
}
