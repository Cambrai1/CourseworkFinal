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
    private string itemDescription;
    [SerializeField]
    private Sprite itemIcon;
    [SerializeField]
    private int HPrestore;
    [SerializeField]
    private int MPrestore;
    [SerializeField]
    private statusEffect StatusEffect;
    private enum statusEffect
    {
        REVIVE,
        AWAKEN,
        CURE,
        HEALTH,
        MANA
    }

	public Element ItemType;
}
