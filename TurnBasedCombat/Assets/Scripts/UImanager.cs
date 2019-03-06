using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UImanager : MonoBehaviour
{
    public BaseHero Hero1Data;
    public GameObject ActionPanel;
    public GameObject buttonPrefab;
    public GameObject canvasParent;
    public GameObject InventoryItemName;
    public GameObject InventoryItemDescription;
    public GameObject HeroPanel;
    bool ActionPanelState = true;
    bool isAttacking = false;
    bool isDefending = false;
    bool isAbility = false;
    bool isFleeing = false;
    int buttonYdif = 40;

    public List<GameObject> InventoryItems;
    public Vector3 Position;

    ItemList Inventories;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Delay", 1);
        Inventories = GetComponent<ItemList>();
    }

    void Delay()
    {
        HeroBarUpdate();
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void HeroBarUpdate()
    {
        Hero1Data.baseHP = (Hero1Data.level * 5) + 50;
        Hero1Data.curHP = Hero1Data.baseHP;
        GameObject.Find("HeroBar1").GetComponentsInChildren<Text>()[0].text = Hero1Data.name;
        GameObject.Find("HeroBar1").GetComponentsInChildren<Text>()[1].text = "HP:  " + Hero1Data.curHP.ToString() + "/" + Hero1Data.baseHP.ToString();
        GameObject.Find("HeroBar1").GetComponentsInChildren<Text>()[2].text = "MP:  " + Hero1Data.curMP.ToString() + "/" + Hero1Data.baseMP.ToString();
    }
    int i = 0;

    public void InstantiatePrefab()
    {
        foreach (var item in Inventories.Hero1Inventory)
        {
            Position.z = 0;
            if (i < 9)
            {
                Position.x = 110;
                Position.y = (-66 - (i * 40));
            }
            else
            {
                Position.x = 325;
                Position.y = (-66 - ((i - 9) * 40));
            }
            GameObject InventoryCreate = Instantiate(buttonPrefab, Position, Quaternion.identity);
            InventoryCreate.transform.SetParent(canvasParent.transform, false);
            InventoryCreate.GetComponentsInChildren<Text>()[0].text = item.itemName;
            InventoryCreate.GetComponentsInChildren<Text>()[1].text = item.itemDescription;
            InventoryCreate.GetComponentsInChildren<Text>()[2].text = item.itemID.ToString();
            i++;
        }
        Debug.Log("Hello");
    }


}
