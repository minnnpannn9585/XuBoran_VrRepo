using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text totalCountdown;
    public float gameDuration;
    public Text levelCountdown;
    public float levelDuration;
    public WallManager wallManager;

    void Update()
    {
        gameDuration -= Time.deltaTime;
        totalCountdown.text = Mathf.CeilToInt(gameDuration).ToString();

        levelDuration -= Time.deltaTime;
        levelCountdown.text = Mathf.CeilToInt(levelDuration).ToString();

        if (gameDuration <= 0)
        {
            gameDuration = 0;
            totalCountdown.text = "0";
            //EndGame();
        }

        if(levelDuration <= 0)
        {
            wallManager.PassThisLevel();
            //enter next level
        }
    }

    public void ResetLevelCountdown()
    {
        levelDuration = 10f;
        levelCountdown.text = "10";
    }
}
