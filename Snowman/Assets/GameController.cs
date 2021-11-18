using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    public UnityEngine.UI.Button BackButton;

    public void StartGame()
    {
        this.Message.text = "Can you save the Snowman?";
        this.StartButton.gameObject.SetActive(false);
        this.BackButton.gameObject.SetActive(true);
        OpenStartScreen();

    }
    public void Start();
    {
        this.StartButton.gameObject.SetActive(true);
        this.BackButton.gameObject.SetActive(false);
    }
}
