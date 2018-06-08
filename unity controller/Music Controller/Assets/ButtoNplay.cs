using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtoNplay : MonoBehaviour {

    public int buttonValue = 1;
    public string buttonName;
    public static bool canPlay = true;
    public static int mult = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        canPlay = Input.GetButton(buttonName);
        if (canPlay) { mult = 1; }
        else { mult = 0; }
        /*{
            switch (buttonName)
            {
                case "A": buttonValue = 1; break;
                case "X": buttonValue = 2; break;
                case "B": buttonValue = 3; break;
                case "Y": buttonValue = 4; break;
            }*/
            PlayedNote.playedNote = ActiveNote.activeNote + mult * buttonValue;
    }
}
