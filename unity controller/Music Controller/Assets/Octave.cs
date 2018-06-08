using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octave : MonoBehaviour {

    private bool octaveUp;
    private bool octaveDown;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        octaveUp = Input.GetButtonDown("R1");
        octaveDown = Input.GetButtonDown("L1");
        if (octaveUp)
        {
            ActiveNote.activeNote = ActiveNote.activeNote + 8;
        }
        if (octaveDown)
        {
            ActiveNote.activeNote = ActiveNote.activeNote - 8;
        }
    }
}
