﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gavino : MonoBehaviour {

	public string[] pigeonArrivedSentences;
	public string[] pigeonKilledSentences;

	// Use this for initialization
	void Start () {
		TextMesh textMesh = GetComponentInChildren<TextMesh>();
		Pigeon.AnyPigeonArrived.AddListener(() => {
			textMesh.text = pigeonArrivedSentences[Random.Range(0, pigeonArrivedSentences.Length - 1)];
		});

		Pigeon.AnyPigeonKilled.AddListener(() => {
			textMesh.text = pigeonKilledSentences[Random.Range(0, pigeonKilledSentences.Length - 1)];
		});
	}
	
}
