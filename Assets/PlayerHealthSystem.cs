using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthSystem : MonoBehaviour
{
    public int playerHealth = 100;
    public GameObject playerDeathEffect;
    public AudioSource PlayerGotHitAudio;
    public AudioSource PlayerDeathAudio;
    public AudioSource MissionOver;
    public int Respawn;

    public void TakeDamage(int damage)
    {
       playerHealth -= damage;

        if(playerHealth > 0)
        {
            //enemyHitAudio(isSpecialBullet);
        if (PlayerGotHitAudio == null)
            PlayerGotHitAudio = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(PlayerGotHitAudio.clip, transform.position);

        }else {
            if (PlayerDeathAudio == null)
            PlayerDeathAudio = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(PlayerDeathAudio.clip, transform.position);
            //killed();
            //enemyDeathAudio(isSpecialBullet);
            //Die(isSpecialBullet);
            Die();

            //Plane.GetComponent<Score>().IncrementScore();
        }
    }

    public void Die()
    {
        if (MissionOver == null)
            MissionOver = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(MissionOver.clip, transform.position);
        

        Destroy(gameObject);
        SceneManager.LoadScene(Respawn);
    }

}
