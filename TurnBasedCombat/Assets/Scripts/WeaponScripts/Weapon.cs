using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : ScriptableObject
{
    [SerializeField]
    public int weaponID;
    [SerializeField]
    public string weaponName;
    [SerializeField]
    private string weaponDescription;
    [SerializeField]
    private Sprite weaponIcon;
    [SerializeField]
    private int weaponDamage;
    [SerializeField]
    private int weaponAccuracy;

}
