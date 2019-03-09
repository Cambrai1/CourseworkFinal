using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UImanager : MonoBehaviour
{
    public BattleEngine TurnData;
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

    public GameObject targetEnemyButtonPrefab;
    public GameObject targetEnemyCanvasParent;

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
        TurnData.HeroData = TurnData.Hero1Data;
    }

    void Delay()
    {
        HeroBarUpdate();
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(TurnData.FightStates);
    }

    public void HeroBarUpdate()
    {
        GameObject.Find("HeroBar1").GetComponentsInChildren<Text>()[0].text = TurnData.Hero1Data.name;
        GameObject.Find("HeroBar1").GetComponentsInChildren<Text>()[1].text = "HP:  " + TurnData.Hero1Data.curHP.ToString() + "/" + TurnData.Hero1Data.baseHP.ToString();
        GameObject.Find("HeroBar1").GetComponentsInChildren<Text>()[2].text = "MP:  " + TurnData.Hero1Data.curMP.ToString() + "/" + TurnData.Hero1Data.baseMP.ToString();

        GameObject.Find("HeroBar2").GetComponentsInChildren<Text>()[0].text = TurnData.Hero2Data.name;
        GameObject.Find("HeroBar2").GetComponentsInChildren<Text>()[1].text = "HP:  " + TurnData.Hero2Data.curHP.ToString() + "/" + TurnData.Hero2Data.baseHP.ToString();
        GameObject.Find("HeroBar2").GetComponentsInChildren<Text>()[2].text = "MP:  " + TurnData.Hero2Data.curMP.ToString() + "/" + TurnData.Hero2Data.baseMP.ToString();

        GameObject.Find("HeroBar3").GetComponentsInChildren<Text>()[0].text = TurnData.Hero3Data.name;
        GameObject.Find("HeroBar3").GetComponentsInChildren<Text>()[1].text = "HP:  " + TurnData.Hero3Data.curHP.ToString() + "/" + TurnData.Hero3Data.baseHP.ToString();
        GameObject.Find("HeroBar3").GetComponentsInChildren<Text>()[2].text = "MP:  " + TurnData.Hero3Data.curMP.ToString() + "/" + TurnData.Hero3Data.baseMP.ToString();

        GameObject.Find("HeroBar4").GetComponentsInChildren<Text>()[0].text = TurnData.Hero4Data.name;
        GameObject.Find("HeroBar4").GetComponentsInChildren<Text>()[1].text = "HP:  " + TurnData.Hero4Data.curHP.ToString() + "/" + TurnData.Hero4Data.baseHP.ToString();
        GameObject.Find("HeroBar4").GetComponentsInChildren<Text>()[2].text = "MP:  " + TurnData.Hero4Data.curMP.ToString() + "/" + TurnData.Hero4Data.baseMP.ToString();
    }
    

    public void InstantiateInventoryPrefab()
    {
        int i = 0;

        foreach (var item in TurnData.HeroData.Inventory)
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
    public void InstantiateAbilitiesPrefab()
    {
        int i = 0;
        foreach (var Ability in TurnData.HeroData.Abilities)
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
            if (Ability.manaCost > TurnData.HeroData.curMP)
            {
                AbilityCreate.GetComponent<Button>().interactable = false;
            }
            i++;
        }
        Debug.Log("AbilitiesYAYYY");
    }

    public void InstantiateTargetEnemyPrefab()
    {
        int i = 0;
        foreach (var targetEnemy in TurnData.baseEnemies)
        {
            Position.z = 0;
            Position.x = -7;
            Position.y = (-20 - (i * 40));
            GameObject targetEnemyCreate = Instantiate(targetEnemyButtonPrefab, Position, Quaternion.identity);
            targetEnemyCreate.transform.SetParent(targetEnemyCanvasParent.transform, false);
            targetEnemyCreate.GetComponentsInChildren<Text>()[0].text = targetEnemy.enemyName;
            targetEnemyCreate.GetComponentsInChildren<Text>()[1].text = targetEnemy.enemyCurHP.ToString();
            targetEnemyCreate.GetComponentsInChildren<Text>()[2].text = targetEnemy.enemyID.ToString();
            i++;
        }
    }

    //public void setTarget()
    //{
    //    foreach(var targetEnemy in TurnData.baseEnemies)
    //    {
    //        if(gameObject.GetComponentsInChildren<Text>()[2].text == targetEnemy.enemyID.ToString())
    //        {
    //            TurnData.EnemyData = targetEnemy;
    //        }
    //        Debug.Log("SetTarget WORKING");
    //    }
    //}

}
