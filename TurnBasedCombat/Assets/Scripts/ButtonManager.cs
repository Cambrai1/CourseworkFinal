﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour, IPointerEnterHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(gameObject.GetComponentInChildren<Text>().text);
        GameObject.Find("ItemNameText").GetComponentInChildren<Text>().text = gameObject.GetComponentsInChildren<Text>()[0].text;
        GameObject.Find("ItemDescriptionText").GetComponentInChildren<Text>().text = gameObject.GetComponentsInChildren<Text>()[1].text;
    }
}
