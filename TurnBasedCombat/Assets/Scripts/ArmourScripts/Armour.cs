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
    public string armourDescription;
    [SerializeField]
    public Sprite armourIcon;
    [SerializeField]
    public int armourDefence;
}
