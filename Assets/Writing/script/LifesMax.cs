using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifesMax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            SceneManager.LoadScene("Interface");
        }
    }

    public void PiumPium()
    {
        if (transform.childCount > 0)
        {
            GameObject lifeless = transform.GetChild(0).gameObject;
            Destroy (lifeless);
        }
    }
}
