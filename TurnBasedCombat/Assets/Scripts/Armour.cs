using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ArmourPiece", menuName = "Armour", order = 52)]
public class Armour : ScriptableObject
{
    [SerializeField]
    private string armourName;
    [SerializeField]
    private string armourDescription;
    [SerializeField]
    private Sprite armourIcon;
    [SerializeField]
    private int armourDefence;
    [SerializeField]
    private armourType ArmourType;
    private enum armourType
    {
        MELEE,
        RANGED,
        MAGIC
    }
    [SerializeField]
    private armourStyle ArmourStyle;
    private enum armourStyle
    {
        HelmetSlot,
        AmuletSlot,
        ChestSlot,
        LegSlot,
        SheildSlot,
        GloveSlot,
        RingSlot,
        BootSlot
    }
}
