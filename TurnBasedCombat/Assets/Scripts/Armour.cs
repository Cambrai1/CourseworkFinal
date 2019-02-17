using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ArmourPiece", menuName = "Armour", order = 52)]
public class Armour : ScriptableObject
{
    [SerializeField]
    public int armourID;
    [SerializeField]
    public string armourName;
    [SerializeField]
    private string armourDescription;
    [SerializeField]
    private Sprite armourIcon;
    [SerializeField]
    private int armourDefence;

    public Element ArmourType;
    public Element ArmourStyle;
}
