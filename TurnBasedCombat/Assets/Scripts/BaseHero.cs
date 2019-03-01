using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hero", menuName = "Hero", order = 55)]

public class BaseHero : ScriptableObject
{
    [SerializeField]
    public string name;
    [SerializeField]
    [Range(1, 99)] public int level;

    [SerializeField]
    public int experience;
    [SerializeField]
    public int experienceLeft;

    [SerializeField]
    public float baseHP;
    [SerializeField]
    public float baseMP;
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
    public float curHP;
    [SerializeField]
    public float curMP;
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

    public enum baseHeroAbilities
    {
        DragonSlash,
        MetalSlash,
        WaterSlash,
        RockSlash
    }

    [SerializeField]
    public baseHeroAbilities baseHeroAbility;

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
