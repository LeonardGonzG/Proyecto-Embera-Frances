using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FrenchQuiz : MonoBehaviour
{
    public TMP_Text TmpText;

    public Text[] OptionsText;

    private string[,] Answers = {
        {"Bonjour","Au revoir","A tout à l’heure"},
        {"Truite", "Tigre" , "Oiseau"},
        {"Courir",  "Se promener", "Regarder"},
        {"Chanter", "Crier", "Parler"},
        {"Magnifiquement", "Sûrement", "Expressément"},
        {"Bonsoir", "Après-midi", "Surtout"},
        {"Autrefois", "Avant", "Ancestral"},
        {"Chemin",  "Territoire",  "Ville"},
        {"S’il te plaît",  "Encore une fois" ,"Merci beaucoup"}
    };
   
    private string[] Questions = { "Buenos días en Francés se dice ... ", 
    "El pájaro en frances", "Andar en francés", "Cantar en francés", "Bonito en francés" , 
    "Buenas tardes en francés", "Ancestral en francés", "Territorio en francés","Muchas gracias en francés" };


    private int QuestionNumber = 0;

    private const int MaxNumberQuestions = 9; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            TmpText.text = Questions[QuestionNumber];
            
            for (int i = 0; i < Answers.GetLength(1) ; i++)
            {
                OptionsText[i].text = Answers[QuestionNumber,i];
            }
        
    }

    public int GetQuestionNumber(){
        return QuestionNumber;
    }

    public void SetQuestionNumber(int NewQuestionNumber){
        if(NewQuestionNumber < MaxNumberQuestions){
            QuestionNumber = NewQuestionNumber;
        }
    }
}
