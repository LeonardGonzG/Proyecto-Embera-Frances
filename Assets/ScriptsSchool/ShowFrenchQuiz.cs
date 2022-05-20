using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFrenchQuiz : MonoBehaviour
{
    public GameObject FrenchQuizMenu;

    public void Show(){
        if(this.gameObject.GetComponentInChildren<Text>().text == "Francés"){
             FrenchQuizMenu.SetActive(true);
        }
       
    }
}
