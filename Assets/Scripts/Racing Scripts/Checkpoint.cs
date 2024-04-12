using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    static public bool hitCheckpoint = false;
    [SerializeField] BoxCollider collider;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter()
    {
        Debug.Log("hit checkpoint");
        hitCheckpoint = true;
        
    }
   
}
