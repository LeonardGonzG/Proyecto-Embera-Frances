using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidateAnswersScript : MonoBehaviour
{

    private string[] CorrectAnswers = {"Bonjour", "Oiseau","Se promener","Chanter","Magnifiquement",
    "Bon Après-midi" , "Ancestral", "Territoire" ,"Merci beaucoup","très heureux"};

    public GameObject FrenchQuizObject;

    private FrenchQuiz Quiz;

    private int QuestionNumber;

    private Text TextBtn;

    private int NumbCorrects = 0;

    // Start is called before the first frame update
    void Start()
    {
        QuestionNumber = FrenchQuizObject.GetComponent<FrenchQuiz>().GetQuestionNumber();
        Quiz = FrenchQuizObject.GetComponent<FrenchQuiz>();
        TextBtn = this.gameObject.GetComponentInChildren<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidateAnswer(){
        QuestionNumber = Quiz.GetQuestionNumber();
        if(CorrectAnswers[QuestionNumber] == TextBtn.text){
            Debug.Log("Correcta");
            NumbCorrects = NumbCorrects + 1;
            Quiz.SetNumbCorrects(NumbCorrects);
        } 
        else{
            Debug.Log("Incorrecta");
        }      
    }

    public void NextQuestion(){
        Quiz.SetQuestionNumber(Quiz.GetQuestionNumber() + 1);
    }
}
