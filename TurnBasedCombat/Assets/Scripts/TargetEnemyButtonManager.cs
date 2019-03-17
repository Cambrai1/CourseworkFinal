using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TargetEnemyButtonManager : MonoBehaviour
{
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
        BattleEngine referenceBattleEngine = GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>();
        DamageManager referenceDamageManager = GameObject.Find("BattleManager").GetComponentInChildren<DamageManager>();

        if (gameObject.GetComponentsInChildren<Text>()[2].text == referenceBattleEngine.Enemy1Data.enemyID.ToString())
        {
            referenceBattleEngine.EnemyData = referenceBattleEngine.Enemy1Data;
        }
        else if (gameObject.GetComponentsInChildren<Text>()[2].text == referenceBattleEngine.Enemy2Data.enemyID.ToString())
        {
            referenceBattleEngine.EnemyData = referenceBattleEngine.Enemy2Data;
        }
        else if (gameObject.GetComponentsInChildren<Text>()[2].text == referenceBattleEngine.Enemy3Data.enemyID.ToString())
        {
            referenceBattleEngine.EnemyData = referenceBattleEngine.Enemy3Data;
        }
        else if (gameObject.GetComponentsInChildren<Text>()[2].text == referenceBattleEngine.Enemy4Data.enemyID.ToString())
        {
            referenceBattleEngine.EnemyData = referenceBattleEngine.Enemy4Data;
        }
        Debug.Log("SetTarget WORKING?????");

        Debug.Log(gameObject.GetComponentsInChildren<Text>()[0].text);

        GameObject.Find("BattleManager").GetComponentInChildren<UImanager>().DeleteItemsPrefab();

        if (referenceBattleEngine.HeroData != referenceBattleEngine.Hero4Data)
        {
            GameObject.Find("BattleManager").GetComponentInChildren<UImanager>().ActionPanel.SetActive(true);
            GameObject.Find("TargetEnemyPanel").SetActive(false);
            GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>().StateControl();
        }
    }
}
