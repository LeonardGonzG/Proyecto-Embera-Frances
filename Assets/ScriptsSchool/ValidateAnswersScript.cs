using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidateAnswersScript : MonoBehaviour
{

    private string[] CorrectAnswers = {"Bonjour"};

    public GameObject FrenchQuizObject;

    private int QuestionNumber;

    // Start is called before the first frame update
    void Start()
    {
        QuestionNumber = FrenchQuizObject.GetComponent<FrenchQuiz>().GetQuestionNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidateAnswer(){
        if(QuestionNumber == 1){
             if( this.gameObject.GetComponentInChildren<Text>().text == CorrectAnswers[0]){
                 Debug.Log("Respuesta Correcta");
             }
             else{
                 Debug.Log("Respuesta Incorrecta");
             }
        }
       
    }
}
