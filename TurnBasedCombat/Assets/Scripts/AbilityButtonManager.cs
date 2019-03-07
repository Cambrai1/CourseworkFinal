using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AbilityButtonManager : MonoBehaviour, IPointerEnterHandler
{
    public BaseHero HeroData;
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
        GameObject.Find("AbilityName").GetComponentInChildren<Text>().text = gameObject.GetComponentsInChildren<Text>()[0].text;
        GameObject.Find("AbilityDescription").GetComponentInChildren<Text>().text = gameObject.GetComponentsInChildren<Text>()[1].text;
        GameObject.Find("AbilityDetails").GetComponentInChildren<Text>().text = "MP: " + gameObject.GetComponentsInChildren<Text>()[3].text + " / " + HeroData.curMP.ToString();
    }
}
