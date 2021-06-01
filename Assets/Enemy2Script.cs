using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy2Script : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigid;
	[SerializeField] float speed;
    public int Respawn;
    public int health=100;
    [SerializeField] Transform Player;
    [SerializeField] bool isFacingRight = false;
   
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player !=null){
            if (Player.transform.position.x < transform.position.x && isFacingRight || Player.transform.position.x > transform.position.x && !isFacingRight)
            {
                Flip();
            }
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
        }
    }

    public void TakeDamage(int damage){
        health-=damage;
        if(health<=0){
            Die();
            
        }
    }

    void Die(){
        Destroy(gameObject);
        //SceneManager.LoadScene(Respawn);
    }
    public void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
    
    
}
