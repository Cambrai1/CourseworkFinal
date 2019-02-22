using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStateMachine : MonoBehaviour
{
    
    public enum HeroValue
    {
        BaseHero,
        BaseHero2,
        BaseHero3,
        BaseHero4
    }
    public enum TurnState
    {
        NOTINFIGHT,
        PROCESSING,
        WAITING,
        SELECTING,
        ACTION,
        DEAD
    }
    public static HeroStateMachine State;
    public TurnState currentState;
    public HeroValue currentHero;
    private float cur_cooldown = 0f;
    private float max_cooldown = 5f;
    // Start is called before the first frame update
    void Start()
    {
        currentState = TurnState.PROCESSING;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log (currentState);

        switch (currentState)
        {
            case (TurnState.NOTINFIGHT):
            
            break;
            case (TurnState.PROCESSING):

            break;
            case (TurnState.WAITING):

            break;
            case (TurnState.SELECTING):

            break;
            case (TurnState.ACTION):

            break;
            case (TurnState.DEAD):

            break;
        }

    }

}
