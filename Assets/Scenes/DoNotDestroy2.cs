using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] healthObj = GameObject.FindGameObjectsWithTag("Health");
       if(healthObj.Length > 1){
           Destroy(this.gameObject);
       }
       DontDestroyOnLoad(this.gameObject);
    }
}

    
