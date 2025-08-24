using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text countdown;
    public float duration;
    public Text passedgames;
    public int passedLevels;
    public WallManager wallManager;


    void Update()
    {
        duration -= Time.deltaTime;
        countdown.text = Mathf.CeilToInt(duration).ToString();

        if(duration <= 0)
        {
            duration = 0;
            countdown.text = "0";
            //EndGame();
        }
        passedLevels = wallManager.passedLevels;
        passedgames.text = Mathf.CeilToInt(passedLevels).ToString();
    }
}
