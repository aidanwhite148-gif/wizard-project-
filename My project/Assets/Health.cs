using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class UnitHealth : MonoBehaviour
{
    int _currentHealth;
    int _currentMaxHealth;

    public int Health
    {
        get
        {
            return _currentHealth;
        }
        set
        {
           _currentHealth = value;

        }

    }


    public int MaxHealth
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;
        }
    }

    public UnitHealth(int Health, int MaxHealth)
    {
        _currentHealth = Health;
        _currentMaxHealth = MaxHealth;
    }
    public void DmgUnit(int dmgAmount)
    {
        if (_currentHealth > 0)
        {
            _currentHealth -= dmgAmount;
        }
    }
    public void HealUnit(int healAmount)
    {
        if (_currentHealth < _currentMaxHealth)
        {
            _currentHealth += healAmount;
        }
        if (_currentHealth > _currentMaxHealth)
        {   
            _currentHealth = _currentMaxHealth;

        }
    }


}
