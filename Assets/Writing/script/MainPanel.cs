using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    private int step = 1;

    private GameObject start;

    public GameObject numLifes;

    private GameObject op;

    private GameObject v1;

    private GameObject v2;

    private GameObject v3;

    private GameObject v4;

    private GameObject v5;

    private GameObject v6;

    // Start is called before the first frame update
    void Start()
    {
        this.start = SetActive("Main", true);
        this.op = SetActive("Info", false);
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
                StartCoroutine(this.waiter(this.v1, this.v2));
                break;
            case 2:
                StartCoroutine(this.waiter(this.v2, this.v3));
                break;
            case 3:
                StartCoroutine(this.waiter(this.v3, this.v4));
                break;
            case 4:
                StartCoroutine(this.waiter(this.v4, this.v5));
                break;
            case 5:
                StartCoroutine(this.waiter(this.v5, this.v6));
                break;
            case 6:
                StartCoroutine(this.waiter(this.v6, null));
                break;
            default:
                break;
        }
        step++;
    }

    IEnumerator waiter(GameObject unactive, GameObject active)
    {
        yield return new WaitForSeconds(2);
        if (unactive != null)
        {
            unactive.SetActive(false);
        }
        if (active != null)
        {
            active.SetActive(true);
        }
    }

    public void StartQuestions()
    {
        this.op.SetActive(true);
        this.v1.SetActive(true);
        this.start.SetActive(false);
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
