using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int numberOfEnemies;
    public static int currentCuredEnemies;

    void Start()
    {
        numberOfEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        currentCuredEnemies = 0;
    }

    void Update()
    {
        if(numberOfEnemies == currentCuredEnemies)
        {
            NextLevel();
        }

    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
