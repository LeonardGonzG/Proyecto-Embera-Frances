using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListCoint : MonoBehaviour
{
     public List<GameObject>  Coint ;
     List<string> cointId ; 
    public Dropdown m_Dropdown;    
    void Start()
    {
       m_Dropdown.ClearOptions();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
      private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("CoinMusic") && collision.gameObject.GetComponent<CointMusic>().GetCoin().active ){
            Coint.Add(collision.gameObject);
            Debug.Log("Libro " + collision.gameObject.GetComponent<CointMusic>().GetId().ToString());
            m_Dropdown.options.Add (new Dropdown.OptionData() {text="Libro " + collision.gameObject.GetComponent<CointMusic>().GetId().ToString()});

            //collision.gameObject.SetActive(false);

                 }
    }
    private void OnTriggerExit2D(Collider2D collision){
        
    }
}
