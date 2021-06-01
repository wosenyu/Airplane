﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlmanagers : MonoBehaviour
{
    public static lvlmanagers instance;

    public Transform respawnPoint;
    public GameObject playerPrefab;

    private void Awake(){
        instance = this;
    }
    public void Respawn(){
        Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
    }
}
