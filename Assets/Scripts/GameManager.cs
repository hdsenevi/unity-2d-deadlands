﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

public BoardManager boardScript;
private int level = 3;

	void Awake () {
		boardScript = GetComponent<BoardManager>();
		InitGame();
	}

	void InitGame() {
		
	}
}
