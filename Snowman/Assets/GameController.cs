using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text Message;
    public Button StartButton;
    public Button BackButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    private WordGuesser.WordGame guessingGame;
    public InputField PlayerGuess;
    public Text GetGuess;
    public Text GetGuessLetters;
    public Text GetGuessesLeft;
    public Text GuessInfo;
    public Text CorrectGuess;


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
        GetGuessLetters.text = this.guessingGame.GetGuessedLetters();
        GetGuessesLeft.text = $"{this.guessingGame.GetGuessLimit()- this.guessingGame.GetIncorrectGuesses()}";
        GetGuess.text = this.guessingGame.GetWord();
        GuessInfo.text = this.guessingGame.CheckGuess(PlayerGuess.text);
        PlayerGuess.text = string.Empty;
    }
    public void CorrectGuesses()
    {
        CorrectGuess.text = this.guessingGame.GetFullWord();
    }
}
