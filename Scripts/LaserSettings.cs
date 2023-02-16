using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSettings : MonoBehaviour
{
    public GameObject laser;
    bool laserStatus;
    void Start()
    {
        laserStatus = true;
        LaserSet(true);
    }

    void Update()
    {
        
    }

    void LaserSet(bool isDone)
    {
        if(isDone)
        {
            if (laserStatus)
            {

                laser.SetActive(false);
                laserStatus = false;
            }
            else
            {
  
                laser.SetActive(true);
                laserStatus = true;
            }
        }
        StartCoroutine(GameObject.Find("Main Camera").GetComponent<CurrentCamera>().GlobalCoroutine(2.0f, LaserSet));
        
    }

    
}
