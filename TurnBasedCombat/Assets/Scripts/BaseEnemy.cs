using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy", order = 54)]
public class BaseEnemy : ScriptableObject
{
    public List<Abilities> Abilities;
    public List<Items> DropTable;
    public List<Items> AlwaysDropTable;

    [SerializeField]
    public int enemyID;
    [SerializeField]
    public int enemyLevel;
    [SerializeField]
    public string enemyName;
    [SerializeField]
    public string enemyDescription;
    [SerializeField]
    public int enemyMaxHP;
    [SerializeField]
    public int enemyCurHP;
    [SerializeField]
    public int enemyMaxMP;
    [SerializeField]
    public int enemyCurMP;
    [SerializeField]
    public int enemyBaseATK;
    [SerializeField]
    public int enemyCurATK;
    [SerializeField]
    public int enemyBaseDEF;
    [SerializeField]
    public int enemyCurDEF;
    [SerializeField]
    public int enemyBaseWIS;
    [SerializeField]
    public int enemyCurWIS;
    [SerializeField]
    public int enemyBaseSTR;
    [SerializeField]
    public int enemyCurSTR;
    [SerializeField]
    public int experienceGranted;

    public bool isDefending = false;
    public int defendingValue;

    [SerializeField]
    public enemyRarity EnemyRarity;
    public enum enemyRarity
    {
        COMMON,
        UNCOMMON,
        RARE,
        SUPERRARE
    }

    public void Awake()
    {
        enemyMaxHP = (int)Mathf.Round(10 + Mathf.Pow(enemyLevel, 1.75f)); 
        enemyMaxMP = (150 / 99 * enemyLevel) + 10;
        enemyBaseATK = (750 / 99 * enemyLevel) + 10;
        enemyBaseSTR = (750 / 99 * enemyLevel) + 10;
        enemyBaseDEF = (750 / 99 * enemyLevel) + 10;
        enemyBaseWIS = (750 / 99 * enemyLevel) + 10;

        enemyCurATK = enemyBaseATK;
        enemyCurSTR = enemyBaseSTR;
        enemyCurDEF = enemyBaseDEF;
        enemyCurWIS = enemyBaseWIS;
        enemyCurHP = enemyMaxHP;
        enemyCurMP = enemyMaxMP;

        experienceGranted = (int)Mathf.Round(333 * Mathf.Pow(enemyLevel, 1.5f));

        defendingValue = enemyBaseDEF / 10;
    }
}
