using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float speed= 20f;
    public Rigidbody2D rb;
    public int damage=50;
    public AudioSource rocketsource;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;

        //if(rocketsound == null){
           rocketsource = GetComponent<AudioSource>(); 
        //}
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy2Script enemy = hitInfo.GetComponent<Enemy2Script>();
        if(enemy != null)
        {
            
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
        
    }
   
}
