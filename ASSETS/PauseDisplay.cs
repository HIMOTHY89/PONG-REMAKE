using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseDisplay : MonoBehaviour
{
  
   public void returnToGame()
   {
       Time.timeScale = 1f; 
       SoundManager.Instance.PlaySound2D("Paddle Collision");
       SceneManager.LoadScene("SampleScene");
      
       
   }
   public void quitGame()
   {
      SoundManager.Instance.PlaySound2D("Paddle Collision");
      SceneManager.LoadScene("DemoScene");

   }
   public void goToPauseMenu()
   {
       Time.timeScale = 1f;
       SoundManager.Instance.PlaySound2D("Paddle Collision");
       SceneManager.LoadScene("PauseMenu");

   }
   

}
