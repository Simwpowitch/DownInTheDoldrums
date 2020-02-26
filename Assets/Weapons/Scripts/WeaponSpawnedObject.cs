﻿using System.Collections.Generic;
using UnityEngine;


public class WeaponSpawnedObject : MonoBehaviour
{
    protected List<Effect> effects = new List<Effect>();
    public float objectLifetime;
    public float speed;

    [HideInInspector]
    public int damage;

    public bool attachToCharacter;

    [HideInInspector]
    public string ignoreTag;

    void Start()
    {
        Destroy(this.gameObject, objectLifetime);
    }

    public void AddEffects(List<Effect> newEffects)
    {
        effects = newEffects;
    }

    public void ApplyDamage(CharacterData characterData)
    {
        characterData.TakeDamage(damage);
    }
}