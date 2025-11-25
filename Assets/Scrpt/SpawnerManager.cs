using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public static SpawnerManager instance;

    public GameObject enemySpawner;
    public GameObject enemySpawner2;
    public GameObject enemySpawner3;
    public GameObject enemySpawner4;
    public GameObject enemySpawner5;
    public GameObject enemySpawner6;

    void Awake()
    {
        instance = this;
    }

    public void SpawnerChange()
    {
        enemySpawner.SetActive(false);
        enemySpawner2.SetActive(false);
        enemySpawner3.SetActive(true);
        enemySpawner4.SetActive(true);
    }

    public void SpawnerChange2()
    {
        enemySpawner3.SetActive(false);
        enemySpawner4.SetActive(false);
        enemySpawner5.SetActive(true);
        enemySpawner6.SetActive(true);
    }

}
