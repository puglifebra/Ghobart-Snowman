using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    public UnityEngine.UI.Button BackButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    private WordGuesser.WordGame guessingGame;
    public UnityEngine.UI.InputField PlayerGuess;
    public UnityEngine.UI.Text GetGuess;
    public UnityEngine.UI.Text GetGuessLetters;
    public UnityEngine.UI.Text GetGuessesLeft;


    public void StartGame()
    {
        this.guessingGame = new WordGuesser.WordGame("apple", 5);
        this.StartScreen.SetActive (false);
        this.PlayScreen.SetActive (true);

        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());
    }

    public void OpenStartScreen()
    {
        this.StartScreen.SetActive (true);
        this.PlayScreen.SetActive (false);
    }

    public void Start()
    {
        this.StartScreen.gameObject.SetActive(true);
        this.PlayScreen.gameObject.SetActive(false);
    }
    
    public void SubmitGuess()
    {
        Debug.Log(this.guessingGame.CheckGuess(PlayerGuess.text));
        PlayerGuess.text = string.Empty;
    }

    public void GetWord()
    {
        GetGuess.text = this.guessingGame.GetWord();
    }
    
    public void GetGuessLetters()
    {
        GetGuessLetters.text = this.guessingGame.GetGuessedLetters();
    }
    public void GetGuessesLeft()
    {
        GetGuessesLeft.text = this.guessingGame.GetGuessesLeft();
    }
}
