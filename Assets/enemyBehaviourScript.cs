using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody2D rigid;
	[SerializeField] float speed;
    [SerializeField] float agro;
    [SerializeField] bool isFacingRight = false;
    public AudioSource EnemyHitAudio;
    //[SerializeField] Vector2 moveDirection = Vector2.left;
    public int health=1000;
    public int damage=50;
    public int Respawn;
    public GameObject dragonDeath;
    public Animator anim;
    [SerializeField] Transform Player;
    
    public void Start()
    {
        
		rigid = GetComponent<Rigidbody2D>();
       
    }
    

    // Update is called once per frame
    public void Update()
    {
        
        //transform.Translate(Vector2.left * Time.deltaTime);
         //if (Vector2.left.x < 0 && isFacingLeft || Vector2.left.x > 0 && !isFacingLeft)
          //  Flip();

        // float disToPlayer=Vector2.Distance(transform.position, Player.position);
        
        // if(disToPlayer <agro){
        //     ChasePlayer();
        // }
        // else{
        //     stopChasingPlayer();
        // }
        //if(Vector2.Distance(transform.position, Player.transform.position) < 4)
        if(Player !=null){
            if (Player.transform.position.x < transform.position.x && isFacingRight || Player.transform.position.x > transform.position.x && !isFacingRight)
            {
                Flip();
            }
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
        }
        

    }

    // void ChasePlayer(){
    //     if(transform.position.x < Player.position.x){
    //         rigid.velocity = new Vector2(speed, 0);
    //         transform.localScale = new Vector2(1,1);
    //     }
    //     else{

    //         rigid.velocity = new Vector2(-speed, 0);
    //         transform.localScale = new Vector2(-1,1);

    //     }
    // }

    // void stopChasingPlayer(){
    //     rigid.velocity = new Vector2(0,0);
    // }

    public void TakeDamage(int damage){
        health-=damage;
        if(health<=0){
            enemyHitAudio();
            Die();
            SceneManager.LoadScene(Respawn);
        }
    }

    public void Die(){

        //Instantiate(dragonDeath, transform.position, Quaternion.identity);
        

        anim.SetBool("isDeath",true);
        
        StartCoroutine(deathDelay());
        //Destroy(gameObject);
    }

    IEnumerator deathDelay(){

        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }

    public void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
    public void enemyHitAudio(){

       if (EnemyHitAudio == null)
            EnemyHitAudio = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(EnemyHitAudio.clip, transform.position);
        
    }
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealthSystem playerHealth = hitInfo.GetComponent<PlayerHealthSystem>();
        if(hitInfo.gameObject.tag == "Player"){
        //Healthbar health = transform.GetComponent<HealthBar>();//there can be a problem with the script
        //Healthbar is name of last sript
            //PlayerHealthSystem playerHealth = hitInfo.GetComponent<PlayerHealthSystem>();
            if (playerHealth != null){
            playerHealth.TakeDamage(damage);
            //TakeDamage it is a void in HealthBar script
            }
        }
    }

        
    
}
