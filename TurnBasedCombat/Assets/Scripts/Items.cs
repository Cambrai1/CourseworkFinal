using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item", order = 53)]
public class Items : ScriptableObject
{

    [SerializeField]
    public int itemID;
    [SerializeField]
    public string itemName;
    [SerializeField]
    public string itemDescription;
    [SerializeField]
    public Sprite itemIcon;
    [SerializeField]
    public int restoreValue;
    [SerializeField]
    public statusEffect StatusEffect;
    public enum statusEffect
    {
        REVIVE,
        HEALTH,
        MANA,
        MULTIRESTORE
    }
}
