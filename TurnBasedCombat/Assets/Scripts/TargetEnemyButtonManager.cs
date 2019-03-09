using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TargetEnemyButtonManager : MonoBehaviour
{
    public BattleEngine TurnData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setTarget()
    {
        foreach (var targetEnemy in TurnData.baseEnemies)
        {
            if (gameObject.GetComponentsInChildren<Text>()[2].text == targetEnemy.enemyID.ToString())
            {
                TurnData.EnemyData = targetEnemy;
            }
            Debug.Log("SetTarget WORKING");
        }
        Debug.Log("SetTarget WORKING");
        Debug.Log(gameObject.GetComponentsInChildren<Text>()[2].text);
    }
}
