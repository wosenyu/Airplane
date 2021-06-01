using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public int Respawn;
    
    
    void onTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("hi");
            SceneManager.LoadScene(Respawn);
        }
    }
}
