using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveManager : MonoBehaviour {

    public GameObject head;
    public GameObject leftHand;
    public GameObject rightHand;

    public static ViveManager Instance; 

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    void OnDestory()
    {
        if (Instance == this)
            Instance = null;
    }

}
