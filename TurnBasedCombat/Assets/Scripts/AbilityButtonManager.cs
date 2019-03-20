using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AbilityButtonManager : MonoBehaviour, IPointerEnterHandler
{
    public BattleEngine referenceBattleEngine;
    public UImanager referenceUImanager;
    // Start is called before the first frame update
    void Start()
    {
        referenceBattleEngine = GameObject.Find("BattleManager").GetComponentInChildren<BattleEngine>();
        referenceUImanager = GameObject.Find("BattleManager").GetComponentInChildren<UImanager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(gameObject.GetComponentInChildren<Text>().text);
        GameObject.Find("AbilityName").GetComponentInChildren<Text>().text = gameObject.GetComponentsInChildren<Text>()[0].text;
        GameObject.Find("AbilityDescription").GetComponentInChildren<Text>().text = gameObject.GetComponentsInChildren<Text>()[1].text;
        GameObject.Find("AbilityDetails").GetComponentInChildren<Text>().text = "MP: " + gameObject.GetComponentsInChildren<Text>()[3].text + " / " + referenceBattleEngine.HeroData.curMP.ToString();
    }

    public void selectAbility()
    {

        string nameOfAbility = GameObject.Find("AbilityName").GetComponentInChildren<Text>().text;

        foreach (var Ability in referenceBattleEngine.HeroData.Abilities)
        {
            if (nameOfAbility == Ability.name)
            {
                referenceBattleEngine.ChosenAbility = Ability;
                Debug.Log("targetAbility is now: " + referenceBattleEngine.ChosenAbility.name);
                referenceBattleEngine.usingAbility = true;
            }
        }
        referenceUImanager.targetEnemyCanvasParent.SetActive(true);
        GameObject.Find("AbilitiesPanel").SetActive(false);
        referenceUImanager.DeleteItemsPrefab();
        referenceUImanager.InstantiateTargetEnemyPrefab();


    }

}
