using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorL1 : MonoBehaviour {
    public string doorLevel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collider)
    {
        //Намагаємося отримати компонент кролика
        HeroRabbit rabit = collider.GetComponent<HeroRabbit>();
        //Впасти міг не тільки кролик
        if (rabit != null)
        {
            SceneManager.LoadScene(doorLevel);
        }
    }
}
