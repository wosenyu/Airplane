using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class DoNotDestroy : MonoBehaviour
{
   private void Awake()
   {
       GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
       if(musicObj.Length > 1){
           Destroy(this.gameObject);
       }
       DontDestroyOnLoad(this.gameObject);
   }
}
