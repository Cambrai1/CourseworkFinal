using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public BattleEngine targetControl;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void heroStandardAttack()
    {
        int Damage = (((targetControl.HeroData.curATK) * (targetControl.HeroData.curATK)) / ((targetControl.HeroData.curATK) + (targetControl.EnemyData.enemyCurDEF)));
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

    void EnemyChoose()
    {
        //attack,defend,ability,flee
        //attack 40%, ability 40%, defend 15%, flee 5%
        var choiceVal = Random.Range(1, 100);
        if (choiceVal > 0 && choiceVal < 41)
        {
            choiceVal = 1;
        }
        if (choiceVal > 40 && choiceVal < 81)
        {
            choiceVal = 2;
        }
        if (choiceVal > 80 && choiceVal < 96)
        {
            choiceVal = 3;
        }
        if (choiceVal > 95 && choiceVal < 101)
        {
            choiceVal = 4;
        }
        switch (choiceVal)
        {
            case 1:
                Debug.Log(choiceVal);
                break;
            case 2:
                Debug.Log(choiceVal);
                break;
            case 3:
                Debug.Log(choiceVal);
                break;
            case 4:
                Debug.Log(choiceVal);
                break;
        }
        
    }
}
