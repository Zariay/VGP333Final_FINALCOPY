using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class FinalScore : MonoBehaviour
{
    int enemyScore;
    public Text enemyScoreText;
    int collectableScore;
    public Text collectableScoreText;
    int objectivesScore;
    int objectivesCount = 0;
    public Text objectivesScoreText;
    int finalScore;
    public Text finalScoreText;
    int bonus = 500;
    int timeRemaining;
    public Text timeRemainingScoreText;

    LevelManager instance;

    // Use this for initialization
    void Start()
    { 
       instance = FindObjectOfType<LevelManager>();

        enemyScore = instance.currentEnemiesKilled * 10;
        enemyScoreText.text = enemyScore.ToString();
        if (instance.currentEnemiesKilled == instance.maxEnemiesToKill)
        {
            enemyScore += bonus;
            objectivesCount++;
        }
        enemyScoreText.text = "Enemies Killed Score: " + enemyScore.ToString();

        collectableScore = instance.currentCollectables * 50;
        collectableScoreText.text = collectableScore.ToString();
        if (instance.currentCollectables == instance.maxCollectables)
        {
            collectableScore += bonus;
            objectivesCount++;
        }

        collectableScoreText.text = "Collectables Score: " + collectableScore.ToString();

        objectivesScore = objectivesCount * 1000;
        objectivesScoreText.text = "Objectives Completed Score: " + objectivesScore.ToString();

        timeRemaining = (int)instance.currentTime * 5;
        timeRemainingScoreText.text = "Time Remaining Score: " + timeRemaining.ToString();

        finalScore = instance.score + enemyScore + collectableScore + objectivesScore + (int)timeRemaining;
        finalScoreText.text = "Final Score: " + finalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //enemyScore = instance.currentEnemiesKilled * 10;
        //enemyScoreText.text = enemyScore.ToString();
        //if (instance.currentEnemiesKilled == instance.maxEnemiesToKill)
        //{
        //    enemyScore += bonus;
        //    objectivesCount++; 
        //}
        //enemyScoreText.text = "Enemies Killed Score: " + enemyScore.ToString();

        //collectableScore = instance.currentCollectables * 50;
        //collectableScoreText.text = collectableScore.ToString();
        //if (instance.currentCollectables == instance.maxCollectables)
        //{
        //    collectableScore += bonus;
        //    objectivesCount++;   
        //}

        //collectableScoreText.text = "Collectables Score: " + collectableScore.ToString();

        //objectivesScore = objectivesCount * 1000;
        //objectivesScoreText.text = "Objectives Completed Score: " + objectivesScore.ToString();

        //timeRemaining = (int)instance.currentTime * 5;
        //timeRemainingScoreText.text = "Time Remaining Score: " + timeRemaining.ToString();

        //finalScore = instance.score + enemyScore + collectableScore + objectivesScore + (int)timeRemaining;
        //finalScoreText.text = "Final Score: " + finalScore.ToString();

    }

}
