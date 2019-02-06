using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy", order = 54)]
public class BaseEnemy : ScriptableObject
{

    [SerializeField]
    private string enemyName;
    [SerializeField]
    private string enemyDescription;
    [SerializeField]
    private int enemyMaxHP;
    [SerializeField]
    private int enemyCurHP;
    [SerializeField]
    private int enemyMaxMP;
    [SerializeField]
    private int enemyCurMP;
    [SerializeField]
    private int enemyBaseATK;
    [SerializeField]
    private int enemyCurATK;
    [SerializeField]
    private int enemyBaseDEF;
    [SerializeField]
    private int enemyCurDEF;
    [SerializeField]
    private enemyRarity EnemyRarity;
    private enum enemyRarity
    {
        COMMON,
        UNCOMMON,
        RARE,
        SUPERRARE
    }
    [SerializeField]
    private enemyType EnemyType;
    private enum enemyType
    {

    }
    [SerializeField]
    private enemyDropTable EnemyDropTable;
    private enum enemyDropTable
    {

    }
    [SerializeField]
    private enemyAbilities EnemyAbilities;
    private enum enemyAbilities
    {

    }

}
