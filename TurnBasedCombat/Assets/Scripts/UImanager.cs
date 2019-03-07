using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UImanager : MonoBehaviour
{
    public BaseHero Hero1Data;
    public GameObject ActionPanel;
    public GameObject inventoryButtonPrefab;
    public GameObject inventoryCanvasParent;
    public GameObject InventoryItemName;
    public GameObject InventoryItemDescription;
    public GameObject HeroPanel;
    public GameObject abilityButtonPrefab;
    public GameObject abilityCanvasParent;
    public GameObject abilityName;
    public GameObject abilityDescription;
    public GameObject abilityManaCost;
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
    

    public void InstantiateInventoryPrefab()
    {
        int i = 0;

        foreach (var item in Hero1Data.Inventory)
        {
            Position.z = 0;
            if (i < 9)
            {
                Position.x = 110;
                Position.y = (-66 - (i * 40));
            }
            if ((i > 8) && (i < 18))
            {
                Position.x = 325;
                Position.y = (-66 - ((i - 9) * 40));
            }
            GameObject InventoryCreate = Instantiate(inventoryButtonPrefab, Position, Quaternion.identity);
            InventoryCreate.transform.SetParent(inventoryCanvasParent.transform, false);
            InventoryCreate.GetComponentsInChildren<Text>()[0].text = item.itemName;
            InventoryCreate.GetComponentsInChildren<Text>()[1].text = item.itemDescription;
            InventoryCreate.GetComponentsInChildren<Text>()[2].text = item.itemID.ToString();
            i++;
        }
        Debug.Log("Hello");
    }

    public void InstantiateAbilitiesPrefab()
    {
        int i = 0;
        foreach (var Ability in Hero1Data.Abilities)
        {
            Position.z = 0;
            if (i < 4)
            {
                Position.x = 59;
                Position.y = (-24 - (i * 40));
            }
            if ((i > 3) && (i < 8))
            {
                Position.x = 174;
                Position.y = (-24 - ((i - 4) * 40));
            }
            if ((i > 7) && (i < 12))
            {
                Position.x = 289;
                Position.y = (-24 - ((i - 8) * 40));
            }
            if ((i > 11) && (i < 16))
            {
                Position.x = 404;
                Position.y = (-24 - ((i - 12) * 40));
            }
            GameObject AbilityCreate = Instantiate(abilityButtonPrefab, Position, Quaternion.identity);
            AbilityCreate.transform.SetParent(abilityCanvasParent.transform, false);
            AbilityCreate.GetComponentsInChildren<Text>()[0].text = Ability.name;
            AbilityCreate.GetComponentsInChildren<Text>()[1].text = Ability.description;
            AbilityCreate.GetComponentsInChildren<Text>()[2].text = Ability.id.ToString();
            AbilityCreate.GetComponentsInChildren<Text>()[3].text = Ability.manaCost.ToString();
            if (Ability.manaCost > Hero1Data.curMP)
            {
                AbilityCreate.GetComponent<Button>().interactable = false;
            }
            i++;
        }
        Debug.Log("AbilitiesYAYYY");
    }

    public void DeleteItemsPrefab()
    {
        GameObject[] itemBtns;
        itemBtns = GameObject.FindGameObjectsWithTag("inventoryBtn");
        foreach (GameObject itemBtn in itemBtns)
        {
            Destroy(itemBtn);
            Debug.Log("Test");
        }
    }

}
