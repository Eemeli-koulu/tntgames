using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public Text textBox;

    public bool timerActive = false;

    void start()
    {
        textBox.text = timeStart.ToString("F2");

    }
    void Update()
    {
        if (timerActive)
        {
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F2");
        }
    }


    void OnTriggerEnter(Collider other)
    {
        timerActive = !timerActive;
    }
}
