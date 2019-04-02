﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMagicWeapon", menuName = "Weapon/Magic Weapon", order = 51)]

public class MagicWeapon : Weapon
{
    [SerializeField]
    public int weaponWIS;
}
