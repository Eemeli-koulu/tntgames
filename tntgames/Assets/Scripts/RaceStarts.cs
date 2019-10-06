using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RaceStarts : MonoBehaviour
{
    public UnityEvent OnGameStart;



    void OnCollisionEnter(Collision col)
    {

        OnGameStart.Invoke();
        Debug.Log("Game start");
        
    }

    void Start()
    {

    }

    
    void Update()
    {
        
    }

}
