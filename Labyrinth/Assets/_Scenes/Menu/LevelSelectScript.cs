﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelSelectScript : MonoBehaviour {

	public Canvas SelectMenu;

	public Canvas tutorialsSelectMenu;
	public Canvas campaignSelectMenu;
	
	public Button tutorialsText;
	public Button campaignText;
	public Button backText;

	public Button levelBackText;

	public Button tutorial1;
	public Button tutorial2;
	public Button tutorial3;
	public Button tutorial4;

	public Button level1;
	public Button level2;
	public Button level3;
	public Button level4;
	public Button level5;
	public Button level6;

	public Text tut2Text;
	public Text tut3Text;
	public Text tut4Text;

	public Text level2Text;
	public Text level3Text;
	public Text level4Text;
	public Text level5Text;
	public Text level6Text;

	public Image tut2Image;
	public Image tut3Image;
	public Image tut4Image;

														public Text score1Text;
	public Image level2Image; public Image score2Image; public Text score2Text;
	public Image level3Image; public Image score3Image; public Text score3Text;
	public Image level4Image; public Image score4Image; public Text score4Text;
	public Image level5Image; public Image score5Image; public Text score5Text;
	public Image level6Image; public Image score6Image; public Text score6Text;

	public Text HighScoreTotal;

	public static bool Tut2Allowed = false; 
	public static bool Tut3Allowed = false; 
	public static bool Tut4Allowed = false; 

	public static bool Level2Allowed = false;
	public static bool Level3Allowed = false;
	public static bool Level4Allowed = false;
	public static bool Level5Allowed = false;
	public static bool Level6Allowed = false;

	void Awake()
	{

		score1Text.text = PlayerPrefs.GetInt("ScoreLevel 1").ToString();
		score2Text.text = PlayerPrefs.GetInt("ScoreLevel 2").ToString();
		score3Text.text = PlayerPrefs.GetInt("ScoreLevel 3").ToString();
		score4Text.text = PlayerPrefs.GetInt("ScoreLevel 4").ToString();
		HighScoreTotal.text =(PlayerPrefs.GetInt("ScoreLevel 1")
							 +PlayerPrefs.GetInt("ScoreLevel 2")
							 +PlayerPrefs.GetInt("ScoreLevel 3")
							 +PlayerPrefs.GetInt("ScoreLevel 4")
							 +PlayerPrefs.GetInt("ScoreLevel 5")
							 +PlayerPrefs.GetInt("ScoreLevel 6")).ToString();

		if(PlayerPrefs.GetInt("Boolean Level 2") == 1)
		Level2Allowed = true;

		if(PlayerPrefs.GetInt("Boolean Level 3") == 1)
		Level3Allowed = true;

		if(PlayerPrefs.GetInt("Boolean level 4") == 1)
		Level4Allowed = true;

		if(PlayerPrefs.GetInt("Boolean level 5") == 1)
			Level5Allowed = true;

		if(PlayerPrefs.GetInt("Boolean level 6") == 1)
			Level6Allowed = true;
	}

	// Use this for initialization
	void Start () 
	{

		//PlayerPrefs.DeleteAll (); //Niet aanraken aub
		HighScoreTotal = HighScoreTotal.GetComponent<Text>();
		

		SelectMenu = SelectMenu.GetComponent<Canvas>();
		tutorialsSelectMenu = tutorialsSelectMenu.GetComponent<Canvas>();
		campaignSelectMenu = campaignSelectMenu.GetComponent<Canvas>();

		tutorialsText = tutorialsText.GetComponent<Button>();
		campaignText = campaignText.GetComponent<Button>();
		backText = backText.GetComponent<Button>();

		levelBackText = levelBackText.GetComponent<Button>();

		tutorial1 = tutorial1.GetComponent<Button>();
		tutorial2 = tutorial2.GetComponent<Button>();
		tutorial3 = tutorial3.GetComponent<Button>();
		tutorial4 = tutorial4.GetComponent<Button>();

		tut2Text = tut2Text.GetComponent<Text>();
		tut3Text = tut3Text.GetComponent<Text>();
		tut4Text = tut4Text.GetComponent<Text>();

		tut2Image = tut2Image.GetComponent<Image>();
		tut3Image = tut3Image.GetComponent<Image>();
		tut4Image = tut4Image.GetComponent<Image>();

		level1 = level1.GetComponent<Button>();
		level2 = level2.GetComponent<Button>();
		level3 = level3.GetComponent<Button>();
		level4 = level4.GetComponent<Button>();
		level5 = level5.GetComponent<Button>();
		level6 = level6.GetComponent<Button>();

		level2Text = level2Text.GetComponent<Text>();
		level3Text = level3Text.GetComponent<Text>();
		level4Text = level4Text.GetComponent<Text>();
		level5Text = level5Text.GetComponent<Text>();
		level6Text = level6Text.GetComponent<Text>();

		level2Image = level2Image.GetComponent<Image>(); score2Image = score2Image.GetComponent<Image>();
		level3Image = level3Image.GetComponent<Image>(); score3Image = score3Image.GetComponent<Image>();
		level4Image = level4Image.GetComponent<Image>(); score4Image = score4Image.GetComponent<Image>();
		level5Image = level5Image.GetComponent<Image>(); score5Image = score5Image.GetComponent<Image>();
		level6Image = level6Image.GetComponent<Image>(); score6Image = score6Image.GetComponent<Image>();

		score1Text = score1Text.GetComponent<Text>();
		score2Text = score2Text.GetComponent<Text>();
		score3Text = score3Text.GetComponent<Text>();
		score4Text = score4Text.GetComponent<Text>();
		score5Text = score5Text.GetComponent<Text>();
		score6Text = score6Text.GetComponent<Text>();

		//buttons
		tutorialsText.enabled = true;
		campaignText.enabled = true;
		backText.enabled = true;

		tutorial1.enabled = false;	
		tutorial2.enabled = false;	
		tutorial3.enabled = false;	
		tutorial4.enabled = false;	

		level1.enabled = false;
		level2.enabled = false;
		level3.enabled = false;
		level4.enabled = false;
		level5.enabled = false;
		level6.enabled = false;

		score2Image.enabled = false;
		score3Image.enabled = false;
		score4Image.enabled = false;
		score5Image.enabled = false;
		score6Image.enabled = false;

		tutorial2.interactable = false; tut2Text.text = "";
		tutorial3.interactable = false;	tut3Text.text = "";
		tutorial4.interactable = false; tut4Text.text = "";

		level2.interactable = false; level2Text.text = ""; score2Text.text = "";
		level3.interactable = false; level3Text.text = ""; score3Text.text = "";
		level4.interactable = false; level4Text.text = ""; score4Text.text = "";
		level5.interactable = false; level5Text.text = ""; score5Text.text = "";
		level6.interactable = false; level6Text.text = ""; score6Text.text = "";


		//canvasses
		SelectMenu.enabled = true;
		tutorialsSelectMenu.enabled = false;
		campaignSelectMenu.enabled = false;

	}

	public void TutorialsPress()
	{
		SelectMenu.enabled = false;
		tutorialsText.enabled = false;
		campaignText.enabled = false;
		backText.enabled = false;

		tutorialsSelectMenu.enabled = true;
		
		tutorial1.enabled = true;
		tutorial2.enabled = true;
		tutorial3.enabled = true;
		tutorial4.enabled = true;

		level1.enabled = false;
		level2.enabled = false;
		level3.enabled = false;
		level4.enabled = false;
		level5.enabled = false;
		level6.enabled = false;
	}

	public void CampaingPress()
	{
		SelectMenu.enabled = false;
		tutorialsText.enabled = false;
		campaignText.enabled = false;
		backText.enabled = false;

		campaignSelectMenu.enabled = true;

		tutorial1.enabled = false;
		tutorial2.enabled = false;
		tutorial3.enabled = false;
		tutorial4.enabled = false;

		level1.enabled = true;
		level2.enabled = true;
		level3.enabled = true;
		level4.enabled = true;
		level5.enabled = true;
		level6.enabled = true;

	}

	public void levelBackPress()
	{
		tutorial1.enabled = false;
		tutorial2.enabled = false;
		tutorial3.enabled = false;
		tutorial4.enabled = false;

		level1.enabled = false;
		level2.enabled = false;
		level3.enabled = false;
		level4.enabled = false;
		level5.enabled = false;
		level6.enabled = false;

		tutorialsText.enabled = true;
		campaignText.enabled = true;
		backText.enabled = true;
		
		SelectMenu.enabled = true;
		tutorialsSelectMenu.enabled = false;
		campaignSelectMenu.enabled = false;
		Application.LoadLevel("LevelSelect");
	}

	public void backPress()
	{
		Application.LoadLevel(0);
	}

//TutorialPresses
	public void Tutorial1Press()
	{
		Application.LoadLevel(2);
	}

	public void Tutorial2Press()
	{
		Application.LoadLevel(3);
	}

	public void Tutorial3Press()
	{
		Application.LoadLevel(4);
	}

	public void Tutorial4Press()
	{
		Application.LoadLevel(5);	
	}

//LevelPresses
	public void Level1Press()
	{
		Application.LoadLevel(6);
	}

	public void Level2Press()
	{
		Application.LoadLevel(7);
	}

	public void Level3Press()
	{
		Application.LoadLevel(8);
	}

	public void Level4Press()
	{
		Application.LoadLevel(9);
	}

	public void Level5Press()
	{
		Application.LoadLevel(10);
	}

	public void Level6Press()
	{
		Application.LoadLevel(11);
	}

//Allowances
	
	void Update()
	{	//TutorialSettings
		if(Tut2Allowed){tutorial2.interactable = true; tut2Text.text = "Reversed"; tut2Image.enabled = false;}
		if(Tut3Allowed){tutorial3.interactable = true; tut3Text.text = "Cannons"; tut3Image.enabled = false;}
		if(Tut4Allowed){tutorial4.interactable = true; tut4Text.text = "Springs"; tut4Image.enabled = false;}

		//LevelSettings
		if(Level2Allowed)
		{level2.interactable = true; level2Text.text = "Level 2"; level2Image.enabled = false; score2Image.enabled = true;
		score2Text.text = PlayerPrefs.GetInt("ScoreLevel 2").ToString();}
		if(Level3Allowed)
		{level3.interactable = true; level3Text.text = "Level 3"; level3Image.enabled = false; score3Image.enabled = true;
		score3Text.text = PlayerPrefs.GetInt("ScoreLevel 3").ToString();}
		if(Level4Allowed)
		{level4.interactable = true; level4Text.text = "Level 4"; level4Image.enabled = false; score4Image.enabled = true;
		score4Text.text = PlayerPrefs.GetInt("ScoreLevel 4").ToString();}
		if(Level5Allowed)
		{level5.interactable = true; level5Text.text = "Level 5"; level5Image.enabled = false; score5Image.enabled = true;
		score5Text.text = PlayerPrefs.GetInt("ScoreLevel 5").ToString();}
		if(Level6Allowed)
		{level6.interactable = true; level6Text.text = "Level 6"; level6Image.enabled = false; score6Image.enabled = true;
			score6Text.text = PlayerPrefs.GetInt("ScoreLevel 6").ToString();}



	}
	
}
	
