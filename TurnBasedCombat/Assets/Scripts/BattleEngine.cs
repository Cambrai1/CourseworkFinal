using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleEngine : MonoBehaviour
{

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
    }

    void update()
    {
        switch (FightStates)
        {
            case (FightState.ENTERFIGHT):

            break;
            case (FightState.HERO1):

            break;
            case (FightState.HERO2):

            break;
            case (FightState.HERO3):

            break;
            case (FightState.HERO4):

            break;
            case (FightState.ENEMY1):

            break;
            case (FightState.ENEMY2):

            break;
            case (FightState.ENEMY3):

            break;
            case (FightState.ENEMY4):

            break;
            case (FightState.END):

            break;

        }
}
        
}

