using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatScreens : MonoBehaviour
{

    public Image Background;
    public Image StatsBackground;
    public Image LifeText;
    public Image BubblesSpawnedText;
    public Image TimeText;
    public Image StarEmpty1;
    public Image StarEmpty2;
    public Image StarEmpty3;
    public Image GameOverText;
    public Image TryAgainText;
    public Image YouDidItText;
    public Image Star1;
    public Image Star2;
    public Image Star3;
    public Image RookieText;
    public Image ProText;
    public Image MasterText;
    public Button BackButton;
    public Button RetryButton;
    public Button NextButton;
    public Text LifeInt;
    public Text BubblesInt;
    public Text TimeInt;

    /// <summary>
    /// Shows the stats-screen when level is lost or finished.
    /// </summary>
    /// <param name="time">Time.</param>
    /// <param name="bubbles">Bubbles.</param>
    /// <param name="life">Life.</param>
    public void ShowStatScreen(int life, int bubbles, int time)
    {
        LifeInt.text = life.ToString();
        BubblesInt.text = bubbles.ToString();
        TimeInt.text = time.ToString();

        if (life == 0)
        {   //condition for game over screen
            Background.gameObject.SetActive(true);
            StatsBackground.gameObject.SetActive(true);
            LifeText.gameObject.SetActive(true);
            LifeInt.gameObject.SetActive(true);
            BubblesSpawnedText.gameObject.SetActive(true);
            BubblesInt.gameObject.SetActive(true);
            TimeText.gameObject.SetActive(true);
            TimeInt.gameObject.SetActive(true);
            StarEmpty1.gameObject.SetActive(true);
            StarEmpty2.gameObject.SetActive(true);
            StarEmpty3.gameObject.SetActive(true);
            GameOverText.gameObject.SetActive(true);
            TryAgainText.gameObject.SetActive(true);
            BackButton.gameObject.SetActive(true);
            RetryButton.gameObject.SetActive(true);
        }
        else if (bubbles > 40)
        {   //condition for rookie screen
            Background.gameObject.SetActive(true);
            StatsBackground.gameObject.SetActive(true);
            YouDidItText.gameObject.SetActive(true);
            Star1.gameObject.SetActive(true);
            RookieText.gameObject.SetActive(true);
            LifeText.gameObject.SetActive(true);
            LifeInt.gameObject.SetActive(true);
            BubblesSpawnedText.gameObject.SetActive(true);
            BubblesInt.gameObject.SetActive(true);
            TimeText.gameObject.SetActive(true);
            TimeInt.gameObject.SetActive(true);
            NextButton.gameObject.SetActive(true);
        }
        else if (bubbles > 30)
        {   //condition for pro screen
            Background.gameObject.SetActive(true);
            StatsBackground.gameObject.SetActive(true);
            YouDidItText.gameObject.SetActive(true);
            Star1.gameObject.SetActive(true);
            Star2.gameObject.SetActive(true);
            ProText.gameObject.SetActive(true);
            LifeText.gameObject.SetActive(true);
            LifeInt.gameObject.SetActive(true);
            BubblesSpawnedText.gameObject.SetActive(true);
            BubblesInt.gameObject.SetActive(true);
            TimeText.gameObject.SetActive(true);
            TimeInt.gameObject.SetActive(true);
            NextButton.gameObject.SetActive(true);
        }
        else if (bubbles < 30)
        {   //condition for master screen
            Background.gameObject.SetActive(true);
            StatsBackground.gameObject.SetActive(true);
            YouDidItText.gameObject.SetActive(true);
            Star1.gameObject.SetActive(true);
            Star2.gameObject.SetActive(true);
            Star3.gameObject.SetActive(true);
            MasterText.gameObject.SetActive(true);
            LifeText.gameObject.SetActive(true);
            LifeInt.gameObject.SetActive(true);
            BubblesSpawnedText.gameObject.SetActive(true);
            BubblesInt.gameObject.SetActive(true);
            TimeText.gameObject.SetActive(true);
            TimeInt.gameObject.SetActive(true);
            NextButton.gameObject.SetActive(true);
        }
    }
    public void DisableScreen()
    {
        Background.gameObject.SetActive(false);
        StatsBackground.gameObject.SetActive(false);
        GameOverText.gameObject.SetActive(false);
        YouDidItText.gameObject.SetActive(false);
        StarEmpty1.gameObject.SetActive(false);
        StarEmpty2.gameObject.SetActive(false);
        StarEmpty3.gameObject.SetActive(false);
        Star1.gameObject.SetActive(false);
        Star2.gameObject.SetActive(false);
        Star3.gameObject.SetActive(false);
        TryAgainText.gameObject.SetActive(false);
        RookieText.gameObject.SetActive(false);
        ProText.gameObject.SetActive(false);
        MasterText.gameObject.SetActive(false);
        LifeText.gameObject.SetActive(false);
        LifeInt.gameObject.SetActive(false);
        BubblesSpawnedText.gameObject.SetActive(false);
        BubblesInt.gameObject.SetActive(false);
        TimeText.gameObject.SetActive(false);
        TimeInt.gameObject.SetActive(false);
        BackButton.gameObject.SetActive(false);
        RetryButton.gameObject.SetActive(false);
        NextButton.gameObject.SetActive(false);
    }

    public void NextButtonClicked()
    {
        Debug.Log("Next clicked");
        // SceneManager.LoadScene("Menu1");
        SceneLoader.instance.LoadLevel(0);
    }

    public void RetryButtonClickled()
    {
        SceneLoader.instance.LoadLevel(GameManager.instance.currentLevel.LevelIndex);
    }

    public void BackButtonClicked()
    {
        SceneLoader.instance.LoadLevel(0);
    }





}
