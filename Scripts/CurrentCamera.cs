using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CurrentCamera : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public IEnumerator GlobalCoroutine(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        
    }
    public IEnumerator GlobalCoroutine(float delayTime, Action<bool> callback)
    {
        yield return new WaitForSeconds(delayTime);
        callback(true);
    }
}
