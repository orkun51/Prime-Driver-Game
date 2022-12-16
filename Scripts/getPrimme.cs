using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class getPrimme : MonoBehaviour
{
    public Text scoreText;
    public Text highscore;
    int score;
   // int highScore;
    [SerializeField] float destroyDelay = 0.0001f;
    public GameObject deathScreen;
    public GameObject finishScreen;
    public GameObject joystick;
    public AudioSource primeSound;
    public AudioSource numberSound;
    public AudioSource deathSound;
    public AudioSource finishSound;
    
    
    
    
    void Start()
    {
        score = 0;
        
        scoreText.text = score.ToString();

        Time.timeScale=1;

        joystick.SetActive(true);

       highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
        
    }

  
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Death"))
        {
           
            deathScreen.SetActive(true);
            Time.timeScale=0;
            joystick.SetActive(false);
            deathSound.Play();
        }

        if(other.gameObject.CompareTag("Primes"))
        {
           
            score += 10;
            scoreText.text = score.ToString();
            Destroy(other.gameObject,destroyDelay); 

            scoreText.text=score.ToString();
            
            if(score > PlayerPrefs.GetInt("HighScore",0))
            {
                PlayerPrefs.SetInt("HighScore", score);
                highscore.text = score.ToString();
            }
            primeSound.Play();
                       
        } 
        if(other.gameObject.CompareTag("Numbers"))
        {
           
            score -= 10;
            scoreText.text = score.ToString();
            Destroy(other.gameObject,destroyDelay); 
            numberSound.Play();
        }
        if(other.gameObject.CompareTag("Finish"))
        {
            finishScreen.SetActive(true);
            Time.timeScale=0;
            joystick.SetActive(false);
            finishSound.Play();
        } 
       
    }      
  
}
