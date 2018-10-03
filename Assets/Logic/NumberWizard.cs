using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;
    [SerializeField] Text headingText;

    int guess;

    public void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        guess = Random.Range(min, ++max);
        guessText.text = guess.ToString();
        headingText.text = ("Guess number between " + min + " and " + max);
    }

    public void OnPressHigher()
    {
        min = ++guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = --guess;
        NextGuess();
    }

    public void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }
}

