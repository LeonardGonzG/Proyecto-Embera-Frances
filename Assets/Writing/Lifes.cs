using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;

public class Lifes : MonoBehaviour
{
    private int lifes = 6;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void minus()
    {
        this.lifes--;
        UnityEngine.Debug.Log(this.ToString());
    }
}
