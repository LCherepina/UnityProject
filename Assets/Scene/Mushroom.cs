using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : Collectable
{
    protected override void OnRabitHit(HeroRabbit rabbit)
    {
        // LevelController.current.addCoins(1);
        rabbit.enlarge();
        this.CollectedHide();
    }
}
