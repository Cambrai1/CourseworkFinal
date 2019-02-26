using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UImanager : MonoBehaviour, IPointerEnterHandler
{

    //public Button m_AttackButton, m_DefendButton, m_AbilitiesButton, m_ItemsButton, m_FleeButton;

    public GameObject ActionPanel;
    public GameObject buttonPrefab;
    public GameObject canvasParent;
    public GameObject InventoryItemName;
    public GameObject InventoryItemDescription;
    public GameObject InventoryItemEffects;

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
        Inventories = GetComponent<ItemList>();
        //m_AttackButton.onClick.AddListener(AttackButtonPress);
        //m_DefendButton.onClick.AddListener(DefendButtonPress);
        //m_AbilitiesButton.onClick.AddListener(AbilitiesButtonPress);
        //m_ItemsButton.onClick.AddListener(ItemsButtonPress);
        //m_FleeButton.onClick.AddListener(FleeButtonPress);
    }

    // Update is called once per frame
    void Update()
    {

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

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(gameObject.GetComponentInChildren<Text>().text);
        GameObject.Find("ItemNameText").GetComponentInChildren<Text>().text = gameObject.GetComponentsInChildren<Text>()[0].text;
        GameObject.Find("ItemDescriptionText").GetComponentInChildren<Text>().text = gameObject.GetComponentsInChildren<Text>()[1].text;

    }
    //public void AttackButtonPress()
    //{
    //    Debug.Log("Attack!");
    //    ActionPanelToggle();
    //    isAttacking = true;
    //}

    //public void DefendButtonPress()
    //{
    //    Debug.Log("Defend!");
    //    ActionPanelToggle();
    //    isDefending = true;
    //}

    //public void AbilitiesButtonPress()
    //{
    //    Debug.Log("Abilities!");
    //    ActionPanelToggle();
    //    isAbility = true;
    //}

    //public void ItemsButtonPress()
    //{
    //    Debug.Log("Items!");
    //    ActionPanelToggle();
    //}

    //public void FleeButtonPress()
    //{
    //    Debug.Log("Flee!");
    //    ActionPanelToggle();
    //    isFleeing = true;
    //}

    //void ActionPanelToggle()
    //{

    //}

}
