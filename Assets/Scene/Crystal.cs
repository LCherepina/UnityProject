using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : Collectable
{
    public int color;
    protected override void OnRabitHit(HeroRabbit rabbit)
    {
         LevelController.current.addCrystals(color);
        this.CollectedHide();
    }
}
