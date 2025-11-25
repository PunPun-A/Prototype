using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highScore;
    

    public int score;
    int highscore;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " POINTS";
        highScore.text = "HIGHSCORE:" + highscore.ToString();
    }

    void Update()
    {
        if(score >= 10)
        {
            UnlockNewSkill.instance.UnlockSkill();
        }
        if(score >= 30)
        {
            UnlockNewSkill.instance.UnlockSkill2();
        }
        if (score >= 50)
        {
            UnlockNewSkill.instance.UnlockSkill3();
        }
        if (score >= 100)
        {
            UnlockLevelAndSkill.instance.UnlockNewLvl();
            SpawnerManager.instance.SpawnerChange();
        }
        if (score >= 200)
        {
            UnlockLevelAndSkill.instance.UnlockNewLvl2();
            SpawnerManager.instance.SpawnerChange2();
        }
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
        if(highscore <= score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
    public void AddRevivePoint()
    {
        score += 50;
        scoreText.text = score.ToString() + " POINTS";
        if (highscore <= score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    
    
}
