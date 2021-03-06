﻿using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class TextLevelHelper
{
	public GameObject twitterView;
	public static string basePath {
		get {
			return "Assets/Levels/";
		}
	}
	int level;
	string fullText;
	string[] tokens;
	string[] textPaths;
	string userId;
	Texture2D picture;

	public TextLevelHelper(TextAsset level, string userId, string imgUrl)
	{
		fullText = level.ToString();
		if (fullText == "") {
			tokens = null;
		}
		else{
			tokens = TextLevelHelper.TokenizeText (fullText);
		}
	}

	static string[] GetPaths() { 
		string[] toReturn = new string[5];
		toReturn.SetValue(basePath+"1.txt",0);
		toReturn.SetValue(basePath+"2.txt",1);
		toReturn.SetValue(basePath+"3.txt",2);
		toReturn.SetValue(basePath+"4.txt",3);
		toReturn.SetValue(basePath+"5.txt",4);
		return toReturn;
	}

	string GetLevelText(int levelNumber,bool isText=true)
	{
		string toReturn = "";
		if (levelNumber - 1 < this.textPaths.Length) {
			string path = this.textPaths [levelNumber - 1];
			//Read the text from directly from the test.txt file
			StreamReader reader = new StreamReader (path); 
			toReturn = reader.ReadToEnd ();
			reader.Close ();
		}
		return toReturn;
	}

	//making it a method so that can be reimplemented, if needed
	static string[] TokenizeText(string text) {
		return text.Split(' ');
	}

	public int GetLevel() {
		return level;
	}

	public string[] GetTokens() {
		return tokens;
	}

	public string[] GetTokens(string text) {
		return TokenizeText(text);
	}

	public string GetFullText() {
		return fullText;
	}

	public void setUserId(string userId) {
		this.userId = userId;
	}
		

	public string getUserId() {
		return this.userId;
	}
}