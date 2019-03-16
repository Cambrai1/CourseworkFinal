using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public BattleEngine targetControl;
    public int Damage;
    public int defIncreaseValue;
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
        Damage = (((targetControl.HeroData.curATK) * (targetControl.HeroData.curATK)) / ((targetControl.HeroData.curATK) + (targetControl.EnemyData.enemyCurDEF)));
        targetControl.EnemyData.enemyCurHP -= Damage;
        Debug.Log(targetControl.HeroData.name + " Has attacked " + targetControl.EnemyData.enemyName + " for " + Damage + "!");
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
        //Targeter 
        int HPsum = (targetControl.Hero1Data.curHP + targetControl.Hero2Data.curHP + targetControl.Hero3Data.curHP + targetControl.Hero4Data.curHP);
        //if the hero hp is high, it produces a smaller HPsum1/2/3/4 value.
        int HPsum1 = HPsum / targetControl.Hero1Data.curHP;
        int HPsum2 = HPsum / targetControl.Hero2Data.curHP;
        int HPsum3 = HPsum / targetControl.Hero3Data.curHP;
        int HPsum4 = HPsum / targetControl.Hero4Data.curHP;
        var TargetSum = Random.Range(1, (HPsum1 + HPsum2 + HPsum3 + HPsum4));
        if (TargetSum > 0 && TargetSum <= (HPsum1))
        {
            //Target Hero1
            Debug.Log("Hero1 Targeted!");
        }
        else if(TargetSum > HPsum1 && TargetSum <= (HPsum1 + HPsum2)){
            //Target Hero2
            Debug.Log("Hero2 Targeted!");
        }
        else if (TargetSum > (HPsum1 + HPsum2) && TargetSum <= (HPsum1 + HPsum2 + HPsum3)){
            //Target Hero3
            Debug.Log("Hero3 Targeted!");
        }
        else if (TargetSum > (HPsum1 + HPsum2 + HPsum3) && TargetSum <= (HPsum1 + HPsum2 + HPsum3 + HPsum4))
        {
            //Target Hero4
            Debug.Log("Hero4 Targeted!");
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
                Damage = (((targetControl.EnemyData.enemyCurATK) * (targetControl.EnemyData.enemyCurATK)) / ((targetControl.EnemyData.enemyCurATK) + (targetControl.HeroData.curDEF)));
                Debug.Log(targetControl.EnemyData.enemyName + " Has attacked " + targetControl.HeroData.name + " for " + Damage + "!");

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
        
    }
}
