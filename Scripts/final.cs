using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class final : MonoBehaviour
{
    public Text scoreText;
    int score;
   
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
