using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {
    public Text fruitCount = null;
    public Text coinsCount = null;
    int fruitTotal ;
    int fruitAmount=0;
    int coinsAmount = 0;
    int lifes = 3;

    public AudioClip musicBackground = null;
    AudioSource musicBackgroundSource = null;

    AudioSource loseSource = null;
    public AudioClip loseSound = null;

    public GameObject musicOn;
    public GameObject soundOn;

    public GameObject panelLost;
    public GameObject panelLostBacground;

    public GameObject leftHeart;
    public GameObject centerHeart;
    public GameObject rightHeart;

    public GameObject leftCrystal;
    public GameObject centerCrystal;
    public GameObject rightCrystal;



    public static LevelController current;
    void Awake()
    {
        current = this;
    }
    Vector3 startingPosition;
    public void setStartPosition(Vector3 pos)
    {
        this.startingPosition = pos;
    }
    public void onRabitDeath(HeroRabbit rabit)
    {
        //При смерті кролика повертаємо на початкову позицію
        
        lifes--;
        if (lifes == 2)
        {
            rightHeart.SetActive(false);
        }
        if (lifes == 1)
        {
            centerHeart.SetActive(false);
        }

        if (lifes == 0)
        {
            leftHeart.SetActive(false);
            panelLost.SetActive(true);
            panelLostBacground.SetActive(true);
            if (SoundManager.Instance.isSoundOn())
                loseSource.Play();
           
        }
            
        if(lifes != 0)
            rabit.transform.position = this.startingPosition;
        
    
       
    }
    void Start()
    {
        
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("ChooseLevel"))
        {
            musicBackgroundSource = gameObject.AddComponent<AudioSource>();
            musicBackgroundSource.clip = musicBackground;
            musicBackgroundSource.loop = true;

            if(MusicManager.Instance.setMusicOn()) 
                musicBackgroundSource.Play();

            loseSource = gameObject.AddComponent<AudioSource>();
            loseSource.clip = loseSound;

            fruitTotal = FindObjectsOfType<Fruit>().Length;
            fruitCount.text = "0" + "/" + fruitTotal;

            leftCrystal.SetActive(false);
            centerCrystal.SetActive(false);
            rightCrystal.SetActive(false);

        }

        coinsCount.text = "0000" ;
        
    }
    public void MusicON()
    {
        MusicManager.Instance.setMusicOn(true);
        musicOn.SetActive(true);
        musicBackgroundSource.Play();
    }

    public void MusicOFF()
    {
        MusicManager.Instance.setMusicOn(false);
        musicOn.SetActive(false);
        musicBackgroundSource.Stop();
    }

    public void SoundON()
    {
        SoundManager.Instance.setSoundOn(true);
        soundOn.SetActive(true);
        
    }

    public void SoundOFF()
    {
        SoundManager.Instance.setSoundOn(false);
        soundOn.SetActive(false);
       
    }

    public void addFruit()
    {
        fruitAmount += 1;
        fruitCount.text = fruitAmount + "/"+ fruitTotal;
    }
    public void addCoins()
    {
        coinsAmount += 1;
     
        string label = "";

        if (coinsAmount < 10)
        {
            label = "000" + coinsAmount;
        }
        else if (coinsAmount < 100 && coinsAmount >= 10)
        {
            label = "00" + coinsAmount;
        }
        else if (coinsAmount < 1000 && coinsAmount >= 100)
        {
            label = "0" + coinsAmount;
        }
        else if (coinsAmount >= 1000)
        {
            label = "" + coinsAmount;
        }

        coinsCount.text = label;

    }
    public void addCrystals(int color)
    {
        if (color == 1)
        {
            rightCrystal.SetActive(true);
        }
        if (color == 2)
        {
            centerCrystal.SetActive(true);
        }
        if (color == 3)
        {
            leftCrystal.SetActive(true);
            
        }
    }
}
