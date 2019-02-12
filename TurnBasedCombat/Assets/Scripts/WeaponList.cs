using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class WeaponList : MonoBehaviour
{
    private Dictionary<int, Weapons> m_WeaponMap = new Dictionary<int, Weapons>();
    public List<Weapons> Weapons;

    private void Awake()
    {
        foreach (var weapon in Weapons)
        {
            m_WeaponMap.Add(weapon.weaponID, weapon);
        }
    }

    public Weapons Get(int id)
    {
        return m_WeaponMap[id];
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
