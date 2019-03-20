using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BattleEngine : MonoBehaviour
{
    public DamageManager damageScript;

    public BaseHero Hero1Data;
    public BaseHero Hero2Data;
    public BaseHero Hero3Data;
    public BaseHero Hero4Data;
    public BaseHero HeroData;
    public List<BaseHero> baseHeros = new List<BaseHero>();

    public BaseEnemy Enemy1Data;
    public BaseEnemy Enemy2Data;
    public BaseEnemy Enemy3Data;
    public BaseEnemy Enemy4Data;
    public BaseEnemy EnemyData;
    public List<BaseEnemy> baseEnemies = new List<BaseEnemy>();

    public GameObject EnemyCharPrefab;
    public Abilities ChosenAbility;

    public bool usingAbility = false;

    public void setUsingAbilityToFalse()
    {
        usingAbility = false;
    }

    public enum HeroDecisions
    {
        ATTACK,
        ABILITY,
        DEFEND,
        ITEM,
        FLEE
    }

    public HeroDecisions HeroDecision;

    public enum FightState {
        ENTERFIGHT,
        HERO1,
        HERO2,
        HERO3,
        HERO4,
        ENEMY1,
        ENEMY2,
        ENEMY3,
        ENEMY4,
        END
    }

    public FightState FightStates;

    void Start()
    {
        FightStates = FightState.ENTERFIGHT;
        StateControl();

        if(Hero1Data != null)
        {
            baseHeros.Add(Hero1Data);
        }
        if (Hero2Data != null)
        {
            baseHeros.Add(Hero2Data);
        }
        if (Hero3Data != null)
        {
            baseHeros.Add(Hero3Data);
        }
        if (Hero4Data != null)
        {
            baseHeros.Add(Hero4Data);
        }

        if (Enemy1Data != null)
        {
            baseEnemies.Add(Enemy1Data);
        }
        if (Enemy2Data != null)
        {
            baseEnemies.Add(Enemy2Data);
        }
        if (Enemy3Data != null)
        {
            baseEnemies.Add(Enemy3Data);
        }
        if (Enemy4Data != null)
        {
            baseEnemies.Add(Enemy4Data);
        }

        Enemy1Data.enemyCurHP = Enemy1Data.enemyMaxHP;
        Enemy2Data.enemyCurHP = Enemy2Data.enemyMaxHP;
        Enemy3Data.enemyCurHP = Enemy3Data.enemyMaxHP;
        Enemy4Data.enemyCurHP = Enemy4Data.enemyMaxHP;
        Hero1Data.curHP = Hero1Data.baseHP;
        Hero2Data.curHP = Hero2Data.baseHP;
        Hero3Data.curHP = Hero3Data.baseHP;
        Hero4Data.curHP = Hero4Data.baseHP;
        //m_SelectedTarget.onClick.AddListener(AssignTarget);
        Debug.Log("Double Call Test");
        InstantiateEnemies();
        Invoke("Delay", 1);
    }

    void update()
    {
        Debug.Log(FightStates.ToString());
    }

    void Delay()
    {
        StateControl();
    }

    public void allDeadCheck()
    {
        if ((Enemy1Data.enemyCurHP <= 0) && (Enemy2Data.enemyCurHP <= 0) && (Enemy3Data.enemyCurHP <= 0) && (Enemy4Data.enemyCurHP <= 0))
        {
            FightStates = FightState.END;
            StateControl();
        }
    }

    public void StateControl()
    {

        switch (FightStates)
        {
            case (FightState.ENTERFIGHT):
                Debug.Log("Fight has been entered!");
                FightStates = FightState.HERO1;
                break;
            case (FightState.HERO1):

                allDeadCheck();
                FightStates = FightState.HERO2;
                if (Hero1Data.curHP > 0)
                {
                    Debug.Log("Its now Hero1's Turn!!");
                    HeroData = Hero1Data;
                }
                else
                {
                    Debug.Log(Hero1Data.name + " has fainted and cannot fight!");
                    StateControl();
                }

                break;
            case (FightState.HERO2):
                Debug.Log("Its now Hero2's Turn!!");
                HeroData = Hero2Data;
                FightStates = FightState.HERO3;
                allDeadCheck();
                
                break;
            case (FightState.HERO3):
                Debug.Log("Its now Hero3's Turn!!");
                HeroData = Hero3Data;
                FightStates = FightState.HERO4;
                allDeadCheck();
                break;
            case (FightState.HERO4):                
                Debug.Log("Its now Hero4's Turn!!");
                HeroData = Hero4Data;
                FightStates = FightState.ENEMY1;
                allDeadCheck();
                break;
            case (FightState.ENEMY1):
                allDeadCheck();
                if (Enemy1Data.enemyCurHP > 0)
                {
                    Debug.Log("Its now Enemy1's Turn!!");
                    EnemyData = Enemy1Data;
                    damageScript.EnemyChooseAndAttack();
                }
                else
                {
                    Debug.Log(Enemy1Data.enemyName + " is dead and cannot fight!");
                }
                FightStates = FightState.ENEMY2;
                Invoke("Delay", 2);
                break;
            case (FightState.ENEMY2):
                if (Enemy2Data.enemyCurHP > 0)
                {
                    Debug.Log("Its now Enemy2's Turn!!");
                    EnemyData = Enemy2Data;
                    damageScript.EnemyChooseAndAttack();
                }
                else
                {
                    Debug.Log(Enemy2Data.enemyName + " is dead and cannot fight!");
                }
                FightStates = FightState.ENEMY3;
                Invoke("Delay", 2);
                break;
            case (FightState.ENEMY3):
                if (Enemy3Data.enemyCurHP > 0)
                {
                    Debug.Log("Its now Enemy3's Turn!!");
                    EnemyData = Enemy3Data;
                    damageScript.EnemyChooseAndAttack();
                }
                else
                {
                    Debug.Log(Enemy3Data.enemyName + " is dead and cannot fight!");
                }
                FightStates = FightState.ENEMY4;
                Invoke("Delay", 2);
                break;
            case (FightState.ENEMY4):
                if (Enemy4Data.enemyCurHP > 0)
                {
                    Debug.Log("Its now Enemy4's Turn!!");
                    EnemyData = Enemy4Data;
                    damageScript.EnemyChooseAndAttack();
                }
                else
                {
                    Debug.Log(Enemy4Data.enemyName + " is dead and cannot fight!");
                }
                FightStates = FightState.HERO1;
                GameObject.Find("BattleManager").GetComponentInChildren<UImanager>().ActionPanel.SetActive(true);
                Invoke("Delay", 0);
                break;
            case (FightState.END):
                Debug.Log("Fight has Ended!");
                SceneManager.LoadScene(sceneName: "EnvironmentScene");
                break;

        }
    }

    public void InstantiateEnemies()
    {
        GameObject[] enemyPrefabs;
        enemyPrefabs = GameObject.FindGameObjectsWithTag("enemyPrefab");
        foreach (GameObject enemies in enemyPrefabs)
        {
            Destroy(enemies);
        }
        float i = 0;
        foreach (var enemyChar in baseEnemies)
        {
            if (enemyChar.enemyCurHP > 0)
            {
                GameObject EnemyCharCreate = Instantiate(EnemyCharPrefab);
                EnemyCharCreate.transform.position = new Vector3(-3f + (i * 2f), 0.5f, 5f);

                i++;
            }
        }
    }
}

