using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyManager : MonoBehaviour
{
    public BallScript ballScript;
    public float easySpeed ;
    public float mediumSpeed ;
    public float hardSpeed ;

   

    
    public void SetDifficulty( string name)
    {
        if (name == "EASY")
        {
            PlayerPrefs.SetString("difficulty", "EASY");
            SceneManager.LoadScene("SampleScene");
        }
        else if (name == "MEDIUM")
        {
            PlayerPrefs.SetString("difficulty", "MEDIUM");
            SceneManager.LoadScene("SampleScene");
        }
        else if (name == "HARD")
        {
            PlayerPrefs.SetString("difficulty", "HARD");
            SceneManager.LoadScene("SampleScene");
        }
        string difficulty = PlayerPrefs.GetString("difficulty");

        switch (difficulty)
        {
            case "EASY":
               
                ballScript.ballspeed = easySpeed;
                break;
            case "MEDIUM":
                
                ballScript.ballspeed = mediumSpeed;
                break;
            case "HARD":
               
                ballScript.ballspeed = hardSpeed;
                break;
           
        }
    }   
    
}
