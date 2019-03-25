using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryButtonManager : MonoBehaviour, IPointerEnterHandler
{
    public UImanager referenceUImanager;
    // Start is called before the first frame update
    void Start()
    {
        referenceUImanager = GameObject.Find("BattleManager").GetComponentInChildren<UImanager>();
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

    public void DeleteItemsPrefab()
    {
        GameObject[] itemBtns;
        itemBtns = GameObject.FindGameObjectsWithTag("inventoryBtn");
        foreach(GameObject itemBtn in itemBtns)
        {
            Destroy(itemBtn);
            Debug.Log("Test");
        }
    }

    public int i;

    public void onClick()
    {
        foreach (var item in GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.Inventory)
        {
            if (gameObject.GetComponentsInChildren<Text>()[0].text == item.itemName)
            {
                GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().ChosenItem = item;
            }
        }

        referenceUImanager.targetEnemyCanvasParent.SetActive(true);
        GameObject.Find("InventoryPanel").SetActive(false);
        referenceUImanager.DeleteItemsPrefab();
        referenceUImanager.InstantiateTargetHeroPrefab();
    }
}
