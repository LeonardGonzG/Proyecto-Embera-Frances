using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FrenchQuiz : MonoBehaviour
{
    public TMP_Text TmpText;

    public Text[] OptionsText;

    public Button[]  OptionsButton;

    private string[] OptionsFirstQuestion = {"Bonjour","Au revoir","A tout à l’heure"};

    private string[] Questions = { "Buenos días en Francés se dice ... "};


    private int QuestionNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(QuestionNumber == 1){
            TmpText.text = Questions[0];
            for (int i = 0; i < 3; i++)
            {
                OptionsText[i].text = OptionsFirstQuestion[i];
            }
        }
    }

    public int GetQuestionNumber(){
        return QuestionNumber;
    }
}
