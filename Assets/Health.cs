﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float _health;

    public void AddDamage(float damage)
    {
        _health -= damage;
        if (_health <= 0)
            Destroy(gameObject);

    }
}
