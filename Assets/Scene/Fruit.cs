using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : Collectable
{
    protected override void OnRabitHit(HeroRabbit rabbit)
    {
        // LevelController.current.addCoins(1);
        this.CollectedHide();
    }
}
