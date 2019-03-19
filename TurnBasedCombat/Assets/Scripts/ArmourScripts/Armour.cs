using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armour : ScriptableObject
{
    [SerializeField]
    public int armourID;
    [SerializeField]
    public string armourName;
    [SerializeField]
    private string armourDescription;
    [SerializeField]
    private Sprite armourIcon;
    [SerializeField]
    private int armourDefence;
}
