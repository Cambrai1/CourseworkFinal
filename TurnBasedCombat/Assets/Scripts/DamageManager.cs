using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public BattleEngine targetControl;
    public UImanager UIdetails;

    public float Damage;
    public int defIncreaseValue;
    public bool isDefending;
    public float DamageMultiplier;

    public int HPsum;
    public int HPsum1;
    public int HPsum2;
    public int HPsum3;
    public int HPsum4;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void heroStandardAttack()
    {
        DamageMultiplier = ((float)Random.Range(75, 125)) / 100;
        Damage = (((targetControl.HeroData.curATK) * (targetControl.HeroData.curATK)) / ((targetControl.HeroData.curATK) + (targetControl.EnemyData.enemyCurDEF)));

        Damage *= DamageMultiplier;
        Damage = Mathf.Floor(Damage);

        targetControl.EnemyData.enemyCurHP -= (int)Damage;

        Debug.Log(targetControl.HeroData.name + " Has attacked " + targetControl.EnemyData.enemyName + " for " + Damage + "!");
        if (targetControl.EnemyData.enemyCurHP <= 0)
        {
            Debug.Log(targetControl.EnemyData.enemyName + " has fainted!");
            targetControl.InstantiateEnemies();
        }
    }

    void heroAbilityAttackSolo()
    {

    }

    void heroAbilityAttackAll()
    {

    }

    void heroDefend()
    {

    }

    public void EnemyChooseAndAttack()
    {
        HPsum = 0;
        foreach (var Hero in targetControl.baseHeros)
        {
            if (Hero.curHP < 0)
            {
                Hero.curHP = 0;
            }
            HPsum += Hero.curHP;
            Debug.Log("HPsum = " + HPsum);
        }
        //if the hero hp is high, it produces a smaller HPsum1/2/3/4 value.
        
        //HPsum2 = HPsum / targetControl.Hero2Data.curHP;
        //HPsum3 = HPsum / targetControl.Hero3Data.curHP;
        //HPsum4 = HPsum / targetControl.Hero4Data.curHP;
        if (targetControl.Hero1Data.curHP < 1)
        {
            HPsum1 = 0;
        }
        else
        {
            HPsum1 = HPsum / targetControl.Hero1Data.curHP;
        }
        if (targetControl.Hero2Data.curHP < 1)
        {
            HPsum2 = 0;
        }
        else
        {
            HPsum2 = HPsum / targetControl.Hero2Data.curHP;
        }
        if (targetControl.Hero3Data.curHP < 1)
        {
            HPsum3 = 0;
        }
        else
        {
            HPsum3 = HPsum / targetControl.Hero3Data.curHP;
        }
        if (targetControl.Hero4Data.curHP < 1)
        {
            HPsum4 = 0;
        }
        else
        {
            HPsum4 = HPsum / targetControl.Hero4Data.curHP;
        }

        var TargetSum = Random.Range(1, (HPsum1 + HPsum2 + HPsum3 + HPsum4));
        if (TargetSum > 0 && TargetSum <= (HPsum1))
        {
            //Target Hero1
            Debug.Log("Hero1 Targeted!");
            targetControl.HeroData = targetControl.Hero1Data;
        }
        else if(TargetSum > HPsum1 && TargetSum <= (HPsum1 + HPsum2)){
            //Target Hero2
            Debug.Log("Hero2 Targeted!");
            targetControl.HeroData = targetControl.Hero2Data;
        }
        else if (TargetSum > (HPsum1 + HPsum2) && TargetSum <= (HPsum1 + HPsum2 + HPsum3)){
            //Target Hero3
            Debug.Log("Hero3 Targeted!");
            targetControl.HeroData = targetControl.Hero3Data;
        }
        else if (TargetSum > (HPsum1 + HPsum2 + HPsum3) && TargetSum <= (HPsum1 + HPsum2 + HPsum3 + HPsum4))
        {
            //Target Hero4
            Debug.Log("Hero4 Targeted!");
            targetControl.HeroData = targetControl.Hero4Data;
        }
        //attack,defend,ability,flee
        //attack 40%, ability 40%, defend 15%, flee 5%
        var choiceVal = Random.Range(1, 100);
        if (choiceVal > 0 && choiceVal < 41)
        {
            choiceVal = 1;
        }
        else if (choiceVal > 40 && choiceVal < 81)
        {
            choiceVal = 2;
        }
        else if (choiceVal > 80 && choiceVal < 96)
        {
            choiceVal = 3;
        }
        else if (choiceVal > 95 && choiceVal < 101)
        {
            choiceVal = 4;
        }
        switch (choiceVal)
        {
            case 1:
                //standard attack
                Debug.Log("Enemy Chose to Standard Attack!");
                DamageMultiplier = ((float)Random.Range(75, 125))/100;

                Damage = (((targetControl.EnemyData.enemyCurATK) * (targetControl.EnemyData.enemyCurATK)) / ((targetControl.EnemyData.enemyCurATK) + (targetControl.HeroData.curDEF)));
                Debug.Log(targetControl.EnemyData.enemyName + " Has attacked " + targetControl.HeroData.name + " for " + Damage + "!");

                Damage *= DamageMultiplier;
                Damage = Mathf.Floor(Damage);

                targetControl.HeroData.curHP -= (int)Damage;
                break;
            case 2:
                //ability use
                Debug.Log("Enemy Chose To Use An Ability!");
                foreach (var Ability in targetControl.EnemyData.Abilities)
                {

                }
                break;
            case 3:
                //defend
                Debug.Log("Enemy Chose to Defend!");
                if (isDefending == true)
                {
                    targetControl.EnemyData.enemyCurDEF -= defIncreaseValue;
                    isDefending = false;
                }
                defIncreaseValue = targetControl.EnemyData.enemyCurDEF / 10;
                targetControl.EnemyData.enemyCurDEF += defIncreaseValue;
                break;
            case 4:
                //flee
                Debug.Log("Enemy Chose to Try and Flee!");

                break;
        }
        DamageReturner();
        UIdetails.HeroBarUpdate();
    }

    public void DamageReturner()
    {
       if (targetControl.HeroData.name == targetControl.Hero1Data.name)
        {
            targetControl.Hero1Data = targetControl.HeroData;
        }
        else if (targetControl.HeroData.name == targetControl.Hero2Data.name)
        {
            targetControl.Hero2Data = targetControl.HeroData;
        }
        else if (targetControl.HeroData.name == targetControl.Hero3Data.name)
        {
            targetControl.Hero3Data = targetControl.HeroData;
        }
        else if (targetControl.HeroData.name == targetControl.Hero4Data.name)
        {
            targetControl.Hero4Data = targetControl.HeroData;
        }
    }
}
