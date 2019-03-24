using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryButtonManager : MonoBehaviour, IPointerEnterHandler
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
        int restoreVal = int.Parse(gameObject.GetComponentsInChildren<Text>()[3].text);
        string itemType = gameObject.GetComponentsInChildren<Text>()[4].text;

        switch (itemType)
        {
            case "REVIVE":
                if (GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curHP <= 0)
                {
                    GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curHP += restoreVal;
                    Debug.Log(GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData + " has been revived!");
                }
                else
                {
                    Debug.Log(gameObject.GetComponentsInChildren<Text>()[0].text + " had no effect!");
                }

               i = 0;

                foreach (var item in GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.Inventory)
                {
                    if (item.itemID.ToString() == gameObject.GetComponentsInChildren<Text>()[2].text)
                    {
                        GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.Inventory.RemoveAt(i);
                        break;
                    }

                    i++;
                }
                break;
            case "MANA":
                if (GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curHP > 0)
                {
                    GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curMP += restoreVal;
                    Debug.Log(GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData + " has had MP restored!");
                }
                else
                {
                    Debug.Log(gameObject.GetComponentsInChildren<Text>()[0].text + " had no effect!");
                }

                i = 0;

                foreach (var item in GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.Inventory)
                {
                    if (item.itemID.ToString() == gameObject.GetComponentsInChildren<Text>()[2].text)
                    {
                        GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.Inventory.RemoveAt(i);
                        break;
                    }

                    i++;
                }
                break;
            case "HEALTH":
                if (GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curHP > 0)
                {
                    GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curHP += restoreVal;
                    Debug.Log(GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData + " has been healed!");
                }
                else
                {
                    Debug.Log(gameObject.GetComponentsInChildren<Text>()[0].text + " had no effect!");
                }

                i = 0;

                foreach (var item in GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.Inventory)
                {
                    if (item.itemID.ToString() == gameObject.GetComponentsInChildren<Text>()[2].text)
                    {
                        GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.Inventory.RemoveAt(i);
                        break;
                    }

                    i++;
                }
                break;
            case "MULTIRESTORE":
                if (GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curHP > 0)
                {
                    GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curHP += restoreVal;
                    GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curMP += restoreVal;
                    Debug.Log(GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData + " has been healed and had MP restored!");
                }
                else
                {
                    Debug.Log(gameObject.GetComponentsInChildren<Text>()[0].text + " had no effect!");
                }

                i = 0;

                foreach (var item in GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.Inventory)
                {
                    if (item.itemID.ToString() == gameObject.GetComponentsInChildren<Text>()[2].text)
                    {
                        GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.Inventory.RemoveAt(i);
                        break;
                    }

                    i++;
                }
                break;
        }

        if (GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curHP > GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.baseHP)
        {
            GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curHP = GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.baseHP;
        }
        if (GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curMP > GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.baseMP)
        {
            GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.curMP = GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().HeroData.baseMP;
        }

    }
}
