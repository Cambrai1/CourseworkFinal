using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{

    public BaseEnemy enemy;

    public enum TurnState
    {
        NOTINFIGHT,
        PROCESSING,
        ADDTOLIST,
        WAITING,
        SELECTING,
        ACTION,
        DEAD
    }

    public TurnState currentState;
    // Start is called before the first frame update
    void Start()
    {
        currentState = TurnState.PROCESSING;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case (TurnState.NOTINFIGHT):

                break;
            case (TurnState.PROCESSING):

                break;
            case (TurnState.ADDTOLIST):

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
