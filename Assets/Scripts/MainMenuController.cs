using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    [SerializeField]
    private Text m_HighScore;

    private string m_DefaultHighScoreText;

    #region Initialization
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        m_DefaultHighScoreText = m_HighScore.text;
    }
    private void Start()
    {
        UpdateHighScore();
    }
    #endregion

    public void PlayArena()
    {
        SceneManager.LoadScene("Arena");
    }
    public void PlayArena2()
    {
        SceneManager.LoadScene("Arena 2");
    }
    public void Quit()
    {
        Application.Quit();
    }

    private void UpdateHighScore()
    {
        if (PlayerPrefs.HasKey("HS"))
        {
            m_HighScore.text = m_DefaultHighScoreText.Replace("%S", PlayerPrefs.GetInt("HS").ToString());

        }
        else
        {
            PlayerPrefs.SetInt("HS", 0);
            m_HighScore.text = m_DefaultHighScoreText.Replace("%S", "0");
        }
    }

    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("HS", 0);
        UpdateHighScore();
    }
}
