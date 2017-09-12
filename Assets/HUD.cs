using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : BallManager {

    public float gameTimer = 600f;
    public Text gameTimerText;
    public GameObject GameTimer;

    // Use this for initialization
    void Start () {
        GameTimer.SetActive(true);
        Mercy.SetActive(false);
        Mercy.SetActive(false);
        MHFS.SetActive(false);
        MAFS.SetActive(false);
    }
    new void Update()
    {
        gameTimer -= Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minuntes = (int)(gameTimer / 60) % 60;

        string timerString = string.Format("{0:00}:{1:00}", minuntes, seconds);

        gameTimerText.text = timerString;

        if (gameTimer <= 0)
        {
            Mercy.SetActive(true);
            MHFS.SetActive(true);
            MAFS.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
 

}
