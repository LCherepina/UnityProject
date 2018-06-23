using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Collectable
{
    protected override void OnRabitHit(HeroRabbit rabbit)
    {
       // LevelController.current.addCoins(1);
        rabbit.hitBomb();
        this.CollectedHide();
    }
}
