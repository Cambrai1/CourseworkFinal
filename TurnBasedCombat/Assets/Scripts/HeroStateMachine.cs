using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStateMachine : MonoBehaviour
{
    private Dictionary<string, BaseHero> m_HeroMap = new Dictionary<string, BaseHero>();
    public List<BaseHero> Heros;
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
    // Start is called before the first frame update
    void Start()
    {
        currentState = TurnState.PROCESSING;
        foreach (var hero in Heros)
        {
            m_HeroMap.Add(hero.name, hero);
            Debug.Log(hero.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log (currentState);

    }

    void StateControl()
    {
        switch (currentState)
        {
            case (TurnState.NOTINFIGHT):

                break;
            case (TurnState.PROCESSING):
                currentState = TurnState.WAITING;
                break;
            case (TurnState.WAITING):
                currentState = TurnState.SELECTING;
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
