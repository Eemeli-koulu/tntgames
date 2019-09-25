using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RaceStarts : MonoBehaviour
{
    public UnityEvent start;

    void OnCollisionEnter(Collision col)
    {
        start.Invoke();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
