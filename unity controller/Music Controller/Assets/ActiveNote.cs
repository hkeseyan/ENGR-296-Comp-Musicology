using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ActiveNote : MonoBehaviour {

    public static double activeNote = 50;

    public Text activeNoteText;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (activeNoteText != null)
        {
            activeNoteText.text = activeNote.ToString();
        }

    }

    public void ResetActiveNote()
    {
        activeNote = 50;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

