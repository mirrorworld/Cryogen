﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperTurret : BaseTurret
{
    [HideInInspector] public string headName = "TurretGuns";
    [HideInInspector] public string childName = "gun_turret_sniper";
    public Animation animation;
    // Start is called before the first frame update
    void Start()
    {
        setTurret(gameObject.transform.Find(childName).Find(headName).gameObject);
        setAnim(animation);
        setCooldown();
        setHP();
    }

    // Update is called once per frame
    void Update()
    {
        aimTurretAtEnemies();
    }
}
