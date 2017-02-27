using UnityEngine;
using System.Collections;
using System.Timers;
using System;
using System.Collections.Generic;

public class TileManager : MonoBehaviour {

    public GameObject currentTile;
    public GameObject[] tilePreFabs; 

    private float distance = 3.0f;
    private static int randIndex;
    private float spawnTime = 0.3f;

    private Stack<GameObject> leftTiles = new Stack<GameObject>();
    private Stack<GameObject> topTiles = new Stack<GameObject>();

    // Use this for initialization
    void Start () {

        CreateTiles(100);
        InvokeRepeating("spawnTile", spawnTime, spawnTime);
        
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void CreateTiles(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            leftTiles.Push(Instantiate(tilePreFabs[0]));
            topTiles.Push(Instantiate(tilePreFabs[1]));
            leftTiles.Peek().SetActive(false);
            topTiles.Peek().SetActive(false);
        }
    }

    public void spawnTile()
    {
        if(leftTiles.Count == 0 || topTiles.Count == 0)
        {
            CreateTiles(10);
        }
        int randIndex = UnityEngine.Random.Range(0, 2);

        if (randIndex == 0)
        {
            GameObject tmp = leftTiles.Pop();
            tmp.SetActive(true);
            //Place a new box to the right of the current Box
            currentTile = (GameObject)Instantiate(tmp, currentTile.transform.position - (currentTile.transform.right * distance), transform.rotation);
        }
        else
        {
            GameObject tmp = topTiles.Pop();
            tmp.SetActive(true);
            //Place a new box to the top of the current Box
            currentTile = (GameObject)Instantiate(tmp, currentTile.transform.position + (currentTile.transform.forward * distance), transform.rotation);
        }
    }
}
