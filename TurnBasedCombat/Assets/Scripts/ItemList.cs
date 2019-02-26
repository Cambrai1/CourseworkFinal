using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class ItemList : MonoBehaviour
{
    private Dictionary<int, Items> m_ItemMap = new Dictionary<int, Items>();
    //private Dictionary<int, Items> m_Hero1InventoryMap = new Dictionary<int, Items>();

    public List<Items> Items;
    public List<Items> Hero1Inventory;
    public List<Items> Hero2Inventory;
    public List<Items> Hero3Inventory;
    public List<Items> Hero4Inventory;

    private void Awake()
    {
        foreach (var item in Items)
        {
            m_ItemMap.Add(item.itemID, item);
        }
        //foreach (var item in Hero1Inventory)
        //{
        //    m_Hero1InventoryMap.Add(item.itemID, item);
        //}
    }

    public Items Get(int id)
    {
        return m_ItemMap[id];
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(m_ItemMap[0].itemName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
