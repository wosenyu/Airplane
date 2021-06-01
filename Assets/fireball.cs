using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    [SerializeField] GameObject fireballPrefab;
    public Transform firePoint;
    //public GameObject firedSpark;
    //public bool alienAutoFireHardMode;
    //public AudioSource alienAutoFireHardMode;   //For hardMode
    //[SerializeField] GameObject AlienProjectile;
    //public bool soundOfFire = false;
    //PlayerHealthSystem player;
    float fireRate;// = 2f;
    float nextFire;// = Time.time;

    // Start is called before the first frame update
    void Start()
    {
         fireRate = 2f;
         nextFire = Time.time;    
    }

   
    void Update()
    {
        
       CheckIfTimeToFire();//player);
    }

    void CheckIfTimeToFire()//PlayerHealthSystem hitInfo)
    {
        
        if(Time.time > nextFire)//player.playerHealth != 0)
            
        {    
            //Instantiate(firedSpark, firePoint.position, Quaternion.identity);
            
            
            Instantiate(fireballPrefab, firePoint.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
          
        }

    }

}

    
