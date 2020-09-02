using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    private int score;
    private int highScore;

    private string highScoreKey = "highScore";

    void Start()
    {
        Initialize();
        //scoreText.color = new Color(0.5f, 0.5f, 0.5f);
    }

    /// <summary>
    /// 数値の初期化
    /// </summary>
    private void Initialize()
    {
        score = 0;

        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }
  
    /// <summary>
    /// 加点
    /// </summary>
    /// <param name="point">加算するポイント</param>
    public void AddPoint (int point)
    {
        score += point;

        Debug.Log(score);

        if(highScore < score)
        {
            highScore = score;

            Debug.Log(highScore);
        }
        DisplayScores();
    }

    /// <summary>
    /// 点数を画面に表示する
    /// </summary>
    private void DisplayScores()
    {
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
        
    }

    /// <summary>
    /// ハイスコアの保存
    /// </summary>
    public void save()
    {
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();
        Initialize();
    }
    
}
