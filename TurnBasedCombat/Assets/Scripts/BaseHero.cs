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
    public Weapon weaponField;
    [SerializeField]
    public Helmet EquippedHelmet;
    [SerializeField]
    public Chestplate EquippedChestplate;
    [SerializeField]
    public Legguards EquippedLegguards;
    [SerializeField]
    public Boots EquippedBoots;

    [SerializeField]
    public string name;
    [SerializeField]
    [Range(1, 99)] public int level;

    [SerializeField]
    public int experience;
    [SerializeField]
    public int experienceNeeded;

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

    //public enum heroTypes
    //{
    //    Warrior,
    //    Priest,
    //    Mage,
    //    MartialArtist,
    //    Thief,
    //    Gladiator
    //}

    //[SerializeField]
    //public heroTypes heroType;

    public void Awake()
    {
        baseHP = (800 / 99 * level) + 10;
        baseMP = (300 / 99 * level) + 10;
        attack = (500 / 99 * level) + 10;
        strength = (500 / 99 * level) + 10;
        defense = (500 / 99 * level) + 10;
        wisdom = (500 / 99 * level) + 10;
        agility = (500 / 99 * level) + 10;

        curHP = baseHP;
        curMP = baseMP;
        curATK = attack;
        curSTR = strength;
        curDEF = defense;
        curWIS = wisdom;
        curAGI = agility;

        experienceNeeded = (int)Mathf.Round(1000 * Mathf.Pow(level, 1.5f));
        LevelStepper();
    }

    public void LevelStepper()
    {
        if (experience > experienceNeeded)
        {
            level++;
            Awake();
            Debug.Log("Increase to level: " + level);
        }
    }
}
