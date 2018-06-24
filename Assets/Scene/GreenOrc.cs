using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenOrc : MonoBehaviour {
    public Vector3 pointA;
    public Vector3 pointB;
    
    
    public float speed = 1;
    float value;

    Transform heroParent = null;
    Rigidbody2D myBody = null;
    SpriteRenderer sr = null;

    Mode mode;

   
    //  float value = this.getDirection();
    float getDirection() {
        Vector3 rabit_pos = HeroRabbit.lastRabit.transform.position;
        Vector3 my_pos = this.transform.position;

        if (rabit_pos.x > Mathf.Min(pointA.x, pointB.x) && rabit_pos.x < Mathf.Max(pointA.x, pointB.x))
        {
            mode = Mode.Attack;
        }
        else
        {
            if (my_pos.x < pointA.x)
            {
                mode = Mode.GoToB;
            }
            if (my_pos.x > pointB.x)
            {
                mode = Mode.GoToA;
            }

        }
        if (mode == Mode.Attack)
        {
            //Move towards rabit
            if (my_pos.x < rabit_pos.x)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        

        if (mode == Mode.GoToA)
        {
            if (my_pos.x >= pointA.x)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        else if (mode == Mode.GoToB)
        {
            if (my_pos.x <= pointB.x)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        
        return 0;
    }
    public enum Mode
    {
        GoToA,
        GoToB,
        Attack
        //...
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        value = this.getDirection();
        Animator animator = GetComponent<Animator>();
        if (value == -1)
        {
            sr.flipX = false;
        }
        else if (value == 1)
        {
            sr.flipX = true;
        }

    }
}
