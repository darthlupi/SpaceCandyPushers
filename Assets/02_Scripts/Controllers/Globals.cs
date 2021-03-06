﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Globals : MonoBehaviour {

    //Set "globals"
    public static float score;
    public static float comboMulti = 1f;
    public static float comboTimer;

    public static string printText = "score ";
    public static int currentLevel = 1;
    public static Dictionary<int, string> levelToScene = new Dictionary<int, string>();

    //Keyboard inputs dictionary
    public static Dictionary<string, KeyCode> inputK1 = new Dictionary<string, KeyCode>();
    public static Dictionary<string, KeyCode> inputK2 = new Dictionary<string, KeyCode>();
    
    //Controller inputs dictionary
    public static Dictionary<string, string> inputJ1 = new Dictionary<string, string>();
    public static Dictionary<string, string> inputJ2 = new Dictionary<string, string>();
    

    // Use this for initialization
    void Start () {

        //Setup controllers

        //Keyboard input for player 1
        inputK1.Add("key_left", KeyCode.LeftArrow);
        inputK1.Add("key_right", KeyCode.RightArrow);
        inputK1.Add("key_up", KeyCode.UpArrow);
        inputK1.Add("key_down", KeyCode.DownArrow);
        inputK1.Add("action", KeyCode.M);

        //Keyboard input for player 2
        inputK2.Add("key_left", KeyCode.A);
        inputK2.Add("key_right", KeyCode.D);
        inputK2.Add("key_up", KeyCode.W);
        inputK2.Add("key_down", KeyCode.S);
        inputK2.Add("action", KeyCode.V);

        //Joystick input for player 1
        inputJ1.Add("Horizontal", "Horizontal1");
        inputJ1.Add("Vertical", "Vertical1");
        inputJ1.Add("action", "Fire1");
        //Joystick input for player 2
        inputJ2.Add("Horizontal", "Horizontal2");
        inputJ2.Add("Vertical", "Vertical2");
        inputJ2.Add("action", "Fire2");

        //Setup dictionary to match numeric level to scene
        levelToScene.Add(1, "Level1Scene");
        levelToScene.Add(2, "Level2Scene");
        levelToScene.Add(3, "Level3Scene");
        levelToScene.Add(4, "Level4Scene");
        levelToScene.Add(5, "Level5Scene");
        levelToScene.Add(6, "Level6Scene");
        levelToScene.Add(7, "Level7Scene");
        levelToScene.Add(8, "Level8Scene");

        //Load scene based on numeric level
        SceneManager.LoadScene(levelToScene[currentLevel]);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
