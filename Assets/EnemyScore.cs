using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyScore : MonoBehaviour
{
    [SerializeField] int score = 0;
    //[SerializeField] int totalAmountOfEnemies = 6;
    //public AudioSource missionComplete;
    [SerializeField] Text scoreText;
    [SerializeField] Text sceneText;
    [SerializeField] Text playerText;
    public GameObject Dragon;

    // Start is called before the first frame update
    void Start()
    {
        //DisplayScore();
        DisplayScene();
        DisplayPlayerHealth();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayPlayerHealth();
    }

    // public void IncrementScore(int amountKilled)
    // {
    //     if (amountKilled < 0)


    //         Debug.Log("Invalid; amount may not be less than zero.");
    //     else

    //         score += amountKilled;

    //         DisplayScore(); 

    //     // if (score == totalAmountOfEnemies)
    //     // {
    //     //     missionComplete = GetComponent<AudioSource>();
    //     //     AudioSource.PlayClipAtPoint(missionComplete.clip, transform.position);
    //     // }
    // }

    // public void IncrementScore()
    // {
    //     IncrementScore(1);
    // }

    // public void DisplayScore()
    // {
    //     scoreText.text = "Score: " + score;

    // }

    public void DisplayScene()
    {
        int level = SceneManager.GetActiveScene().buildIndex;
        sceneText.text = "Level: " + level;
    }

    public void DisplayPlayerHealth()
    {
        int enemyHealth = Dragon.GetComponent<enemyBehaviourScript>().health;
        // Debug.Log(playerHealth + "abc");
        // Debug.Log("before");
        playerText.text = "HP: " + enemyHealth;
        // Debug.Log("after");
    }
}
