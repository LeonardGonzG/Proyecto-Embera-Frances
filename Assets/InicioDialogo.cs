using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioDialogo : MonoBehaviour
{
 
    public GameObject PanelQuiz;
 


    
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
            PanelQuiz.SetActive(true);
        }
        

    }

   

}
