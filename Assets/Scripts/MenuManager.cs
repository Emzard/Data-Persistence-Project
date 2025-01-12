using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    public TextMeshProUGUI highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        LoadHighScore();
    }

    public void StartGame()
    {
        PlayerPrefs.SetString("CurrentPlayerName", playerNameInput.text);

        SceneManager.LoadScene(1);
    }
    public void LoadHighScore()
    {
        highScoreText.text = $"High Score: {MainGameManager.Instance.highScore} Name: {MainGameManager.Instance.playerName}";
    }

    public void Quit()
    {
        Application.Quit();
    }
}
