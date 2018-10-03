using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;

    int guess;

    public void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        max = ++max;
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
        guessText.text = guess.ToString();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
        guessText.text = guess.ToString();
    }

    public void NextGuess()
    {
        guess = (max + min) / 2;
    }
}

