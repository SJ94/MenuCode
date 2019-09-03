using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour 
{
	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	//public Image Lock1;
	public Image Lock1;
	public Image Lock2;
	public Image Lock3;
	public Image Lock4;
	public Image Lock5;
	public Image Lock6;
	public Image Lock7;
	public Image Lock8;
	public Button Level1;
	public Button Level2;
	public Button Level3;
	public Button Level4;
	public Button Level5;
	public Button Level6;
	public Button Level7;
	public Button Level8;
	bool lvl1finished = false;
	bool lvl2finished = false;
	bool lvl3finished = false;
	bool lvl4finished = false;
	bool lvl5finished = false;
	bool lvl6finished = false;
	bool lvl7finished = false;
	bool lvl8finished = false;

	
    public bool paused = false;

    public InputField debugInput;

	public void DebugLevelSelect()
	{
		SelectLevel(System.Convert.ToInt32(debugInput.text));
	}


	public void SelectLevel(int _index)
	{
		SceneLoader.instance.LoadLevel(_index);
	}
	public void PlayGame () 
	{
		SceneManager.LoadScene (1);
	}

	public void PlayLvl1 () 
	{
		SceneManager.LoadScene (1);
	}

	public void PlayLvl2 () 
	{
		SceneManager.LoadScene (2);
	}

	public void PlayLvl3 () 
	{
		SceneManager.LoadScene (3);
	}

	public void PlayLvl4 () 
	{
		SceneManager.LoadScene (4);
	}

	public void PlayLvl5 () 
	{
		SceneManager.LoadScene (5);
	}
	public void PlayLvl6 () 
	{
		SceneManager.LoadScene (6);
	}
	public void PlayLvl7 () 
	{
		SceneManager.LoadScene (7);
	}
	public void PlayLvl8 () 
	{
		SceneManager.LoadScene (8);
	}

	public void SetLevelsFinished ()
	{
		if (lvl1finished) {
			Lock1.gameObject.SetActive(false);
			Level1.gameObject.SetActive(true);
		}
		if (lvl2finished) {
			Lock2.gameObject.SetActive(false);
			Level2.gameObject.SetActive(true);
		}
		if (lvl3finished) {
			Lock3.gameObject.SetActive(false);
			Level3.gameObject.SetActive(true);
		}
		if (lvl3finished) {
			Lock3.gameObject.SetActive(false);
			Level3.gameObject.SetActive(true);
		}
		if (lvl4finished) {
			Lock4.gameObject.SetActive(false);
			Level4.gameObject.SetActive(true);
		}
		if (lvl5finished) {
			Lock5.gameObject.SetActive(false);
			Level5.gameObject.SetActive(true);
		}
		if (lvl6finished) {
			Lock6.gameObject.SetActive(false);
			Level6.gameObject.SetActive(true);
		}
		if (lvl7finished) {
			Lock7.gameObject.SetActive(false);
			Level7.gameObject.SetActive(true);
		}
		if (lvl8finished) {
			Lock8.gameObject.SetActive(false);
			Level8.gameObject.SetActive(true);
		}
	}


		
}
