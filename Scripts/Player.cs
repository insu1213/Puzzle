using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public GameObject playerObj;
    public GameObject pointObj;
    public GameObject heartPrf;
    //GameObject[] heartCpObj;
    public int hp;
    public int point;
    public bool keyStatus;
    TextMeshProUGUI pointTxt;
    
    void Start()
    {
        point = 0;
        pointTxt = pointObj.GetComponent<TextMeshProUGUI>();
        keyStatus = false;
        Debug.Log(pointTxt);
    }

    void Update()
    {
        
    }

    public void PointSet(int addPoint)
    {
        point += addPoint;
        
        pointTxt.text = point.ToString();
    }

    public void HeartSet(int heart)
    {
        //for(int i = 0; i < heart; i++)
        //{
        //    heartCpObj[i] = Instantiate(heartPrf, parent)
        //}
    }

    public void Damaged(int damage)
    {
        hp -= damage;
    }
}
