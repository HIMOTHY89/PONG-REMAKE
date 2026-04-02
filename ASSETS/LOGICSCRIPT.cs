using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LOGICSCRIPT : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject RestartButton;
    public int score;
    public Text ScoreText;
    public Text Highscore;
    
    public int highscore;
    
    

    

     

    
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GameOverScreen()
    {

        GameOver.SetActive(true);
     if (score > PlayerPrefs.GetInt("Highscore", 0))
     {
        highscore = score;
        PlayerPrefs.SetInt("Highscore", score);
        Highscore.text =  highscore.ToString();
        PlayerPrefs.Save();
        ADSManager.Instance.intersitialAds.LoadIntersitialAds();
     }
    }
     
    public void RestartGame()
    {
       
         
          SceneManager.LoadScene("SampleScene");   
       
    }
    
     [ContextMenu("ADDScore")]
    
    public void addScore(int points)
    {
        score = score + points;
        ScoreText.text = score.ToString();
    }
    
    
}
