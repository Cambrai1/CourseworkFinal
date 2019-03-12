using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleEngine : MonoBehaviour
{
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

        m_SelectedTarget.onClick.AddListener(AssignTarget);

        Invoke("Delay", 1);
    }

    void update()
    {
        Debug.Log(FightStates);
    }

    void Delay()
    {
        StateControl();
    }

    void StateControl()
    {

        switch (FightStates)
        {
            case (FightState.ENTERFIGHT):
                Debug.Log("Fight has been entered!");
                FightStates = FightState.HERO1;
                break;
            case (FightState.HERO1):
                Debug.Log("Its now Hero1's Turn!!");
                HeroData = Hero1Data;
                break;
            case (FightState.HERO2):
                Debug.Log("Its now Hero2's Turn!!");
                HeroData = Hero2Data;
                break;
            case (FightState.HERO3):
                Debug.Log("Its now Hero3's Turn!!");
                HeroData = Hero3Data;
                break;
            case (FightState.HERO4):
                Debug.Log("Its now Hero4's Turn!!");
                HeroData = Hero4Data;
                break;
            case (FightState.ENEMY1):
                Debug.Log("Its now Enemy1's Turn!!");
                EnemyData = Enemy1Data;
                break;
            case (FightState.ENEMY2):
                Debug.Log("Its now Enemy2's Turn!!");
                EnemyData = Enemy2Data;
                break;
            case (FightState.ENEMY3):
                Debug.Log("Its now Enemy3's Turn!!");
                EnemyData = Enemy3Data;
                break;
            case (FightState.ENEMY4):
                Debug.Log("Its now Enemy4's Turn!!");
                EnemyData = Enemy4Data;
                break;
            case (FightState.END):

                break;

        }
    }
       
    void AssignTarget()
    {
        GameObject.Find("")
    }

}

