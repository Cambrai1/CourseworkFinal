﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon", order = 51)]
public class Weapons : ScriptableObject
{
    [SerializeField]
    private string weaponName;
    [SerializeField]
    private string weaponDescription;
    [SerializeField]
    private Sprite weaponIcon;
    [SerializeField]
    private int weaponDamage;
    [SerializeField]
    private int weaponAccuracy;
    [SerializeField]
    private weaponType WeaponType;
    private enum weaponType
    {
        MELEE,
        RANGED,
        MAGIC
    }
    [SerializeField]
    private weaponElement WeaponElement;
    private enum weaponElement
    {
        WATER,
        FIRE,
        AIR,
        EARTH,
        METAL,
        LIGHT,
        DARK
    }
    [SerializeField]
    private bool twoHanded;

    public string WeaponName
    {
        get
        {
            return weaponName;
        }
    }

    public string WeaponDescription
    {
        get
        {
            return weaponDescription;
        }
    }

    public Sprite WeaponIcon
    {
        get
        {
            return weaponIcon;
        }
    }

    public int WeaponDamage
    {
        get
        {
            return weaponDamage;
        }
    }

    public int WeaponAccuracy
    {
        get
        {
            return weaponAccuracy;
        }
    }

}
