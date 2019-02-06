using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class BaseHero
{
    public string name;

    public float baseHP;
    public float curHP;

    public float baseMP;
    public float curMP;

    public int attack;
    public int strength;
    public int defense;
    public int wisdom;
    public int agility;

    public int curATK;
    public int curSTR;
    public int curDEF;
    public int curWIS;
    public int curAGI;

    public enum baseHeroAbilities
    {
        DragonSlash,
        MetalSlash,
        WaterSlash,
        RockSlash
    }
    
    public baseHeroAbilities baseHeroAbility;

}
