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
        
    }

    void Start()
    {

    }

    
    void Update()
    {
        
    }

}
