﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour {

    //Array of objects to spawn (note I've removed the private goods variable)
    public GameObject[] theGoodies;
 
    //Time it takes to spawn theGoodies
    [Space(3)]
    public float waitingForNextSpawn = 15;
    public float theCountdown = 3;

    // the range of X
    [Header("X Spawn Range")]
    public float xMin;
    public float xMax;

    // the range of y
    [Header("Y Spawn Range")]
    public float yMin;
    public float yMax;


    void Start()
    {
    }

    public void Update()
    {  
        theCountdown -= Time.deltaTime;
        if (theCountdown <= 0)
        {
            SpawnGoodies();
            theCountdown = Random.Range(1, 4); ;
        }
    }


    void SpawnGoodies()
    {
        // Defines the min and max ranges for x and y
        Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));

        // Choose a new goods to spawn from the array (note I specifically call it a 'prefab' to avoid confusing myself!)
        GameObject goodsPrefab = theGoodies[Random.Range(0, theGoodies.Length)];

        // Creates the random object at the random 2D position.
        Instantiate(goodsPrefab, pos, transform.rotation);

        // If I wanted to get the result of instantiate and fiddle with it, I might do this instead:
        //GameObject newGoods = (GameObject)Instantiate(goodsPrefab, pos)
        //newgoods.something = somethingelse;
    }
}
