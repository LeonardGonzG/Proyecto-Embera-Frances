using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class PopUpMenu : MonoBehaviour
{

    public GameObject MyCanvas;

    private Animator anim;

    private TMP_Text Question;

    private  Button[] Btns;



    // Start is called before the first frame update
    void Start()
    {
        anim = MyCanvas.GetComponent<Animator>();
        Question = MyCanvas.GetComponentInChildren<TMP_Text>();
        Btns = MyCanvas.GetComponentsInChildren<Button>();
        MyCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape")){

            anim.SetBool("show",false);
        }
    }

    void OnMouseDown() {
       
        if(this.name == "Tables"){
            anim.SetBool("show",true);
            
        }
        
    }

    public void Close(){

        if(this.gameObject.GetComponentInChildren<Text>() != null && 
        !(this.gameObject.GetComponentInChildren<Text>().text == "Francés")){
             anim.SetBool("show",false);
        }
       
    }

    public void SelectLanguage(){
        Question.text = "Elige el idioma a evaluar";
        Question.alignment =  TextAlignmentOptions.Center;
        Btns[0].GetComponentInChildren<Text>().text = "Francés";
        Btns[1].GetComponentInChildren<Text>().text = "Embera";
    }

}
