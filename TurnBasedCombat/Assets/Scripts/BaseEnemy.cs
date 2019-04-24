using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy", order = 54)]
public class BaseEnemy : ScriptableObject
{
    public List<Abilities> Abilities;
    public List<Items> alwaysDropTable;
    public List<Items> commonDropTable;
    public List<Items> rareDropTable;

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
    public int enemyBaseAGI;
    [SerializeField]
    public int enemyCurAGI;

    [SerializeField]
    public int experienceGranted;

    public bool isDefending = false;
    public int defendingValue;

    [SerializeField]
    public bool BasicEnemy = false;

    public void Awake()
    {
        if (BasicEnemy == true)
        {
            enemyMaxHP = (int)Mathf.Round(10 + Mathf.Pow(enemyLevel, 1.50f));
            enemyMaxMP = (int)(150 / 99 * enemyLevel) + 10;
            enemyBaseATK = (int)Mathf.Round(600 / 99 * enemyLevel) + 10;
            enemyBaseSTR = (int)Mathf.Round(600 / 99 * enemyLevel) + 10;
            enemyBaseDEF = (int)Mathf.Round(600 / 99 * enemyLevel) + 10;
            enemyBaseWIS = (int)Mathf.Round(600 / 99 * enemyLevel) + 10;
            enemyBaseAGI = (int)Mathf.Round(600 / 99 * enemyLevel) + 10;

            enemyCurATK = enemyBaseATK;
            enemyCurSTR = enemyBaseSTR;
            enemyCurDEF = enemyBaseDEF;
            enemyCurWIS = enemyBaseWIS;
            enemyCurHP = enemyMaxHP;
            enemyCurMP = enemyMaxMP;
            enemyCurAGI = enemyBaseAGI;

            experienceGranted = (int)Mathf.Round(333 * Mathf.Pow(enemyLevel, 1.25f));

            defendingValue = enemyBaseDEF / 10;
        }
        
    }
}
