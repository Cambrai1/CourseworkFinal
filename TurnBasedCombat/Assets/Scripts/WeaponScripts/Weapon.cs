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
    public string weaponDescription;
    [SerializeField]
    public Sprite weaponIcon;
    [SerializeField]
    public int weaponDamage;
    [SerializeField]
    public int weaponAccuracy;

}
