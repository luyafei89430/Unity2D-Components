﻿using UnityEngine;
using System.Collections;

public abstract class Weapon : AnimationBehaviour {

    public enum WeaponType { Sword, Bow, Hammer, Projectile };
    public WeaponType weaponType;
    public Sprite sprite;

    [Header("All Weapons")]
    public string title;
    public int hp;
    public int ac;
    public int damage;
    public float rateOfAttack;

    [Header("Projectile Weapons")]
    public float speed;
    public float maxDistance;

    // animation state methods
    public abstract void PlayIdleAnimation(float xOffset, float yOffset);
    public abstract void PlayRunAnimation(float xOffset, float yOffset);
    public abstract void PlayJumpAnimation(float xOffset, float yOffset);
    public abstract void PlaySwingAnimation(float xOffset, float yOffset);

    public abstract void EnableAnimation(bool status);
}
