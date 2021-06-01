using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float playehealth = 100f;
    public GameObject Player;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Dragon")
        {
            playehealth -= 100f;
        }
    }
    private void Update()
    {
        if(playehealth < 0f)
        {
            Destroy(Player);
        }
    }
}
