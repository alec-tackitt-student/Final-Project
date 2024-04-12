using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParkingSpot : MonoBehaviour
{
    [SerializeField] BoxCollider collider;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter()
    {
        Debug.Log("completed Level! , earned points");
        Licence.points += 1;
        Invoke("HomeScreen", 2);
    }
    private void HomeScreen()
    {
        SceneManager.LoadScene("Home Screeen");
    }
}
