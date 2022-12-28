//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class LevelController : MonoBehaviour
//{
//    public static LevelController instance;
//    public GameObject[] totalCheckPoints;
//    public int currentCheckPoint=0;
//    public int check = 0;

//   public void Awake()
//    {
//        if(instance == null)
//        {
//            instance = this;
//        }
//    }

//    public void Start()
//    {
//        //totalCheckPoints[currentCheckPoint-1].SetActive(true);
//    }

//    public void NextCheckPoint()
//    {
//        check++;
//        if (currentCheckPoint <= totalCheckPoints.Length)
//        {
//            totalCheckPoints[currentCheckPoint + 1].SetActive(true);
//            currentCheckPoint++;
//            totalCheckPoints[currentCheckPoint - 1].SetActive(false);
//        }

//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public static LevelController instance;
    public GameObject[] TotalCheckPoints;
    public int currentCheckPoint = 0;
    public int checkPointsCollected;
    public Text checkpointsCollectedText;
    public int totalCheckPoints;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Start()
    {
        //totalCheckPoints[currentCheckPoint-1].SetActive(true);
    }

    public void NextCheckPoint()
    {
        //int a=0;
        //a++;
        if (currentCheckPoint <= totalCheckPoints)
        {
            TotalCheckPoints[currentCheckPoint+1].SetActive(true);
            currentCheckPoint++;
            TotalCheckPoints[currentCheckPoint-1].SetActive(false);
        }

    }
    public void CheckPointDetection()
    {
        checkpointsCollectedText.text = checkPointsCollected + " / " + totalCheckPoints;

    }
}