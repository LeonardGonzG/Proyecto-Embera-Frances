using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject checkedV;

    // Start is called before the first frame update
    void Start()
    {
        this.checkedV.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Active()
    {
        StartCoroutine(this.waiter());
    }

    IEnumerator waiter()
    {
        this.checkedV.SetActive(true);
        yield return new WaitForSeconds(2);
        this.checkedV.SetActive(false);
    }
}
