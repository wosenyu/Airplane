using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform firePoint;
   public GameObject bulletPrefab;
   public AudioSource RocketSound;
   public float fireSpeed = 0.1f;
   private float nextFire = 0.0f;
    // Update is called once per frame
    void Update(){
         if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireSpeed;
            Shoot();

        }
    }
    

    void Shoot(){ 

        if(RocketSound == null){
           RocketSound = GetComponent<AudioSource>(); 
        }
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
