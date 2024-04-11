using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Text))]
public class Licence : MonoBehaviour
{
    public static UnityEvent<object> OnValueChange = new UnityEvent<object>();

    public static int points = 0;

    private Text displayText;

    private void Awake()
    {
        displayText = GetComponent<Text>();

    }
    private void OnLevelWasLoaded(int level)
    {
        displayText.text = "Points: " + points.ToString();
    }
}
