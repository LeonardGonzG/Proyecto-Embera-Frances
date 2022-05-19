using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MainPanel : MonoBehaviour
{
    private int step = 1;

    private GameObject v0;

    private GameObject v1;

    private GameObject v2;

    private GameObject v3;

    private GameObject v4;

    private GameObject v5;

    private GameObject v6;

    // Start is called before the first frame update
    void Start()
    {
        this.v0 = SetActive("MainText", true);
        this.v1 = SetActive("Question1", false);
        this.v2 = SetActive("Question2", false);
        this.v3 = SetActive("Question3", false);
        this.v4 = SetActive("Question4", false);
        this.v5 = SetActive("Question5", false);
        this.v6 = SetActive("Question6", false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Activate()
    {
        switch (this.step)
        {
            case 1:
                this.v1.SetActive(true);
                this.v0.SetActive(false);
                break;
            case 2:
                this.v1.SetActive(false);
                this.v2.SetActive(true);
                break;
            case 3:
                this.v2.SetActive(false);
                this.v3.SetActive(true);
                break;
            case 4:
                this.v3.SetActive(false);
                this.v4.SetActive(true);
                break;
            case 5:
                this.v4.SetActive(false);
                this.v5.SetActive(true);
                break;
            case 6:
                this.v5.SetActive(false);
                this.v6.SetActive(true);
                break;
            default:
                break;
        }
        step++;
    }

    GameObject SetActive(string element, Boolean status)
    {
        GameObject elem = GameObject.Find(element);
        if (elem)
        {
            elem.SetActive (status);
        }
        return elem;
    }
}
