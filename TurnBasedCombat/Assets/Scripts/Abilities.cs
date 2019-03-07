using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ability", menuName = "Ability", order = 56)]

public class Abilities : ScriptableObject
{
    [SerializeField]
    public int id;
    [SerializeField]
    public string name;
    [SerializeField]
    public string description;
    [SerializeField]
    public int manaCost;
    [SerializeField]
    public int baseDamage;
    [SerializeField]
    public attributeTypes attributeType;

    public enum attributeTypes
    {
        Water,
        Air,
        Earth,
        Fire
    }

}
