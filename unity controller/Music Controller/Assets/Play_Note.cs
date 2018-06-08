using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Note : MonoBehaviour {

    public string buttonName;
    public double noteValue = 1;
    public int buttonValue = 1;
    public double noteMult = 1;
    public static bool canPlay = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        canPlay = true;

        Vector3 LJS = Vector3.zero;
        LJS.x = Input.GetAxis("Lx");
        LJS.y = -Input.GetAxis("Ly");

        Vector3 RJS = Vector3.zero;
        RJS.x = Input.GetAxis("Rx");
        RJS.y = -Input.GetAxis("Ry");

        noteValue = Math.Sign(RJS.y*RJS.x)*Math.Round(Math.Sqrt(Math.Pow(2*RJS.y, 2) + Math.Pow(RJS.x, 2)));

        noteMult = Math.Sign(LJS.y*LJS.x) * Math.Round(Math.Sqrt(Math.Pow(LJS.y, 2) + Math.Pow(LJS.x, 2))+.5);

        if (Input.GetButtonDown("Y"))
        {
            buttonValue = 4;
            PlayedNote.playedNote = ActiveNote.activeNote + noteMult * buttonValue;
        }
        if (Input.GetButtonDown("B"))
        {
            buttonValue = 3;
            PlayedNote.playedNote = ActiveNote.activeNote + noteMult * buttonValue;
        }
        if (Input.GetButtonDown("A"))
        {
            buttonValue = 1;
            PlayedNote.playedNote = ActiveNote.activeNote + noteMult * buttonValue;
        }
        if (Input.GetButtonDown("X"))
        {
            buttonValue = 2;
            PlayedNote.playedNote = ActiveNote.activeNote + noteMult * buttonValue;
        }
        if (RJS.y == 0 && RJS.x == 0 && LJS.y == 0 && LJS.x == 0)
        {
            PlayedNote.playedNote = null;
        }
        else if (canPlay)
        {
            PlayedNote.playedNote = ActiveNote.activeNote + noteValue * noteMult + buttonValue * noteMult;
        }
        noteMult = 0;
        noteValue = 0;
        buttonValue = 0;
        canPlay = false;
    }
}
