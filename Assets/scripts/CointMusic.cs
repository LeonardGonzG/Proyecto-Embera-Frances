using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CointMusic : MonoBehaviour
{
    public AudioClip  Music;
    public Canvas  canvas;

    public int Id;

    public string TituleOriginal;
    public string ContentOriginal;
    public string TituleTranslate;
    public string ContentTranslate;
    public AudioSource sourcePlayer;
    [SerializeField] private GameObject  Coin ;

    [SerializeField] private TextMeshProUGUI  TextMeshTituleOriginal ;
    [SerializeField] private TextMeshProUGUI  TextMeshContentOriginal;
    [SerializeField] private TextMeshProUGUI  TextMeshTituleTranslate;
    [SerializeField] private TextMeshProUGUI  TextMeshContentTranslate;


    // Start is called before the first frame update
    void Start()
    {
        TextMeshTituleOriginal.text=TituleOriginal;
        TextMeshContentOriginal.text=ContentOriginal;
        TextMeshTituleTranslate.text=TituleTranslate;
        TextMeshContentTranslate.text=ContentTranslate;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    public void PlayMusisc(){
        sourcePlayer.PlayOneShot(Music);
    }
     public int GetId(){
         return Id;
    
        }
        public GameObject GetCoin(){
            return Coin;

        }
}
