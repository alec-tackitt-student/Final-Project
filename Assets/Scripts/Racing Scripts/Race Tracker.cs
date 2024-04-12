using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class RaceTracker : MonoBehaviour
{

    static public int laps = 0;
    static public float time = 0;

    [SerializeField] BoxCollider collider;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider>();
        StartCoroutine(Timer());
    } 

    private void OnTriggerEnter()
    {
        Debug.Log(laps);
        if(laps == 3)
        {
            Debug.Log("completed Level! , earned points");
            Licence.points += 1;
            Invoke("HomeScreen", 2);
        }
        if (Checkpoint.hitCheckpoint)
        {
            laps++;
            Debug.Log(laps);
            Debug.Log("Completed Lap");
            Checkpoint.hitCheckpoint = false;
        }
        
    }

    private void HomeScreen()
    {
        SceneManager.LoadScene("Home Screeen");
    }

    IEnumerator Timer()
    {
        while (true)
        {
            time += Time.smoothDeltaTime;
            
            yield return null;
        }
    }
}
