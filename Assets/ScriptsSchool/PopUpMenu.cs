using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopUpMenu : MonoBehaviour
{

    public GameObject MyCanvas;

    private Animator anim;

    private TMP_Text Question;

    private  Button[] Btns;

    private Text TextBtn1;
    private Text TextBtn2;    

    // Start is called before the first frame update
    void Start()
    {
        anim = MyCanvas.GetComponent<Animator>();
        Question = MyCanvas.GetComponentInChildren<TMP_Text>();
        Btns = MyCanvas.GetComponentsInChildren<Button>();
        TextBtn1 = Btns[0].GetComponentInChildren<Text>();
        TextBtn2 = Btns[1].GetComponentInChildren<Text>();
        
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
            ShowPopUpMenu();
        }
        
    }

    public void ShowPopUpMenu(){
        anim.SetBool("show",true);
    }

    public void Close(){

        if(this.gameObject.GetComponentInChildren<Text>() != null && 
        (TextBtn1.text == "Francés") || (TextBtn1.text == "Todavía no") || 
        (TextBtn1.text == "Sí") || (TextBtn2.text == "No")){
            anim.SetBool("show",false);
        }
    }

    public void SelectLanguage(){
        if(TextBtn2.text == "Estoy listo"){
            Question.text = "Elige el idioma a evaluar";
            Question.alignment =  TextAlignmentOptions.Center;
            TextBtn1.text = "Francés";
            TextBtn2.text = "Embera";
        }   
    }



    public void ShowAreYouSureWindow(){
        ShowPopUpMenu();
        Question.text = "¿Deseas volver al menú principal?";
        Question.alignment =  TextAlignmentOptions.Center;
        TextBtn1.text = "Sí";
        TextBtn2.text = "No";
    }

    public void BackToMainMenu(){
        if(Question.text == "¿Deseas volver al menú principal?" && TextBtn1.text == "Sí"){
             SceneManager.LoadScene("interface");
        }
    }

}
