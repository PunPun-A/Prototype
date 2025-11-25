using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// The Invoker
// This triggers commands based on events (score changes)
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highScoreText; 

    public int score;
    int highscore;

  
    private Dictionary<int, ICommand> _scoreCommands;

    void Awake()
    {
        instance = this;
        _scoreCommands = new Dictionary<int, ICommand>();
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        UpdateUI();

        InitializeCommands();
    }

   
    void InitializeCommands()
    {

        UnlockNewSkill skillReceiver = UnlockNewSkill.instance;

       
        _scoreCommands.Add(10, new UnlockSkillCommand(skillReceiver, 1));


        _scoreCommands.Add(30, new UnlockSkillCommand(skillReceiver, 2));

       
        _scoreCommands.Add(50, new UnlockSkillCommand(skillReceiver, 3));

    
    }



    public void AddPoint()
    {
        score += 1;
        UpdateUI();
        CheckHighscore();

        
        CheckCommands(score);
    }

    public void AddRevivePoint()
    {
      

        score += 50;
        UpdateUI();
        CheckHighscore();

        CheckCommands(score);
    }

    private void CheckCommands(int currentScore)
    {
 
        if (_scoreCommands.ContainsKey(currentScore))
        {
            _scoreCommands[currentScore].Execute();
        }
    }

    private void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = score.ToString() + " POINTS";

        if (highScoreText != null)
            highScoreText.text = "HIGHSCORE:" + highscore.ToString();
    }

    private void CheckHighscore()
    {
        if (highscore <= score)
        {
            highscore = score; 
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}