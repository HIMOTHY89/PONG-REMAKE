using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class menuscript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
     public void Start()
    {
            LoadVolume();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Difficulty");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("sfxVolume", volume);
    }
    public void SaveVolume(float volume)
    {
        audioMixer.GetFloat("sfxVolume", out float currentVolume);
        PlayerPrefs.SetFloat("sfxVolume", currentVolume);
    }
    public void LoadVolume()
    {
       volumeSlider.value = PlayerPrefs.GetFloat("sfxVolume");
    }
    
    
}
