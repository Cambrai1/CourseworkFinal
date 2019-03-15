using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hero", menuName = "Hero", order = 55)]

public class BaseHero : ScriptableObject
{
    //private Dictionary<int, Abilities> m_AbilityMap = new Dictionary<int, Abilities>();
    public List<Abilities> Abilities;
    public List<Items> Inventory;

    [SerializeField]
    public string name;
    [SerializeField]
    [Range(1, 99)] public int level;

    [SerializeField]
    public int experience;
    [SerializeField]
    public int experienceLeft;

    [SerializeField]
    public int baseHP;
    [SerializeField]
    public int baseMP;
    [SerializeField]
    public int attack;
    [SerializeField]
    public int strength;
    [SerializeField]
    public int defense;
    [SerializeField]
    public int wisdom;
    [SerializeField]
    public int agility;

    [SerializeField]
    public int curHP;
    [SerializeField]
    public int curMP;
    [SerializeField]
    public int curATK;
    [SerializeField]
    public int curSTR;
    [SerializeField]
    public int curDEF;
    [SerializeField]
    public int curWIS;
    [SerializeField]
    public int curAGI;

    public enum heroTypes
    {
        Warrior,
        Priest,
        Mage,
        MartialArtist,
        Thief,
        Gladiator
    }

    [SerializeField]
    public heroTypes heroType;

}
