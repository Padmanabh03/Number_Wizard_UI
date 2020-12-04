using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    int len = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartGame(); 
    }

    void StartGame()
    {
        NextGuess();
        max = max + 1;
    }
    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
        len = len + 1;
    }
    public void OnPressLower()
    {
        max = guess;
        NextGuess();
        len = len + 1;
    }
    void NextGuess()
    {
        guess =(min+max)/2;
        guessText.text = guess.ToString();
    }
        /*else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("The Game took "+len+" chances to find your number");
        }*/
    
}
