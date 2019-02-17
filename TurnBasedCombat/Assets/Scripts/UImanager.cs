using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{

    public Button m_AttackButton, m_DefendButton, m_AbilitiesButton, m_ItemsButton, m_FleeButton;
    public GameObject ActionPanel;
    bool ActionPanelState = true;
    // Start is called before the first frame update
    void Start()
    {
        m_AttackButton.onClick.AddListener(AttackButtonPress);
        m_DefendButton.onClick.AddListener(DefendButtonPress);
        m_AbilitiesButton.onClick.AddListener(AbilitiesButtonPress);
        m_ItemsButton.onClick.AddListener(ItemsButtonPress);
        m_FleeButton.onClick.AddListener(FleeButtonPress);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackButtonPress()
    {
        Debug.Log("Attack!");
        ActionPanelToggle();
    }

    public void DefendButtonPress()
    {
        Debug.Log("Defend!");
        ActionPanelToggle();
    }

    public void AbilitiesButtonPress()
    {
        Debug.Log("Abilities!");
        ActionPanelToggle();
    }

    public void ItemsButtonPress()
    {
        Debug.Log("Items!");
        ActionPanelToggle();
    }

    public void FleeButtonPress()
    {
        Debug.Log("Flee!");
        ActionPanelToggle();
    }

    void ActionPanelToggle()
    {
        ActionPanelState = !ActionPanelState;
        ActionPanel.gameObject.SetActive(ActionPanelState);
    }

}
