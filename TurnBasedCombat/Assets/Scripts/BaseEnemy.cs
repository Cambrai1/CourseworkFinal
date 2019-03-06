using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy", order = 54)]
public class BaseEnemy : ScriptableObject
{
    public List<Abilities> Abilities;
    public List<Items> DropTable;

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
    public enemyRarity EnemyRarity;
    public enum enemyRarity
    {
        COMMON,
        UNCOMMON,
        RARE,
        SUPERRARE
    }
    [SerializeField]
    public enemyType EnemyType;
    public enum enemyType
    {

    }

}
