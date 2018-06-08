using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayedNote : MonoBehaviour {

    public GameObject noteSphere;
    private ulong d = 1000;
    public static bool canSpawn = true;

    public static List<string[]> log = new List<string[]>();
    public int time;
    public int played;

    //public AudioSource[] note = new AudioSource[100];
    public AudioSource n30;
    public AudioSource n31;
    public AudioSource n32;
    public AudioSource n33;
    public AudioSource n34;
    public AudioSource n35;
    public AudioSource n36;
    public AudioSource n37;
    public AudioSource n38;
    public AudioSource n39;
    public AudioSource n40;
    public AudioSource n41;
    public AudioSource n42;
    public AudioSource n43;
    public AudioSource n44;
    public AudioSource n45;
    public AudioSource n46;
    public AudioSource n47;
    public AudioSource n48;
    public AudioSource n49;
    public AudioSource n50;
    public AudioSource n51;
    public AudioSource n52;
    public AudioSource n53;
    public AudioSource n54;
    public AudioSource n55;
    public AudioSource n56;
    public AudioSource n57;
    public AudioSource n58;
    public AudioSource n59;
    public AudioSource n60;
    public AudioSource n61;
    public AudioSource n62;
    public AudioSource n63;
    public AudioSource n64;
    public AudioSource n65;
    public AudioSource n66;
    public AudioSource n67;
    public AudioSource n68;
    public AudioSource n69;

    public static double? playedNote = null;

    public Text playedNoteText;

    // Use this for initialization
    void Start () {
        /*for (int i = 1; i < 100; i++)
        {
           note[i] = GameObject.Find("n"+i).GetComponent<AudioSource>();
        }*/
        n30 = GameObject.Find("n30").GetComponent<AudioSource>();
        n31 = GameObject.Find("n31").GetComponent<AudioSource>();
        n32 = GameObject.Find("n32").GetComponent<AudioSource>();
        n33 = GameObject.Find("n33").GetComponent<AudioSource>();
        n34 = GameObject.Find("n34").GetComponent<AudioSource>();
        n35 = GameObject.Find("n35").GetComponent<AudioSource>();
        n36 = GameObject.Find("n36").GetComponent<AudioSource>();
        n37 = GameObject.Find("n37").GetComponent<AudioSource>();
        n38 = GameObject.Find("n38").GetComponent<AudioSource>();
        n39 = GameObject.Find("n39").GetComponent<AudioSource>();
        n40 = GameObject.Find("n40").GetComponent<AudioSource>();
        n41 = GameObject.Find("n41").GetComponent<AudioSource>();
        n42 = GameObject.Find("n42").GetComponent<AudioSource>();
        n43 = GameObject.Find("n43").GetComponent<AudioSource>();
        n44 = GameObject.Find("n44").GetComponent<AudioSource>();
        n45 = GameObject.Find("n45").GetComponent<AudioSource>();
        n46 = GameObject.Find("n46").GetComponent<AudioSource>();
        n47 = GameObject.Find("n47").GetComponent<AudioSource>();
        n48 = GameObject.Find("n48").GetComponent<AudioSource>();
        n49 = GameObject.Find("n49").GetComponent<AudioSource>();
        n50 = GameObject.Find("n50").GetComponent<AudioSource>();
        n51 = GameObject.Find("n51").GetComponent<AudioSource>();
        n52 = GameObject.Find("n52").GetComponent<AudioSource>();
        n53 = GameObject.Find("n53").GetComponent<AudioSource>();
        n54 = GameObject.Find("n54").GetComponent<AudioSource>();
        n55 = GameObject.Find("n55").GetComponent<AudioSource>();
        n56 = GameObject.Find("n56").GetComponent<AudioSource>();
        n57 = GameObject.Find("n57").GetComponent<AudioSource>();
        n58 = GameObject.Find("n58").GetComponent<AudioSource>();
        n59 = GameObject.Find("n59").GetComponent<AudioSource>();
        n60 = GameObject.Find("n60").GetComponent<AudioSource>();
        n61 = GameObject.Find("n61").GetComponent<AudioSource>();
        n62 = GameObject.Find("n62").GetComponent<AudioSource>();
        n63 = GameObject.Find("n63").GetComponent<AudioSource>();
        n64 = GameObject.Find("n64").GetComponent<AudioSource>();
        n65 = GameObject.Find("n65").GetComponent<AudioSource>();
        n66 = GameObject.Find("n66").GetComponent<AudioSource>();
        n67 = GameObject.Find("n67").GetComponent<AudioSource>();
        n68 = GameObject.Find("n68").GetComponent<AudioSource>();
        n69 = GameObject.Find("n69").GetComponent<AudioSource>();
        /* note[50] = GameObject.Find("n50").GetComponent<AudioSource>();
        note[51] = GameObject.Find("n51").GetComponent<AudioSource>();
        note[52] = GameObject.Find("n52").GetComponent<AudioSource>();
        note[53] = GameObject.Find("n53").GetComponent<AudioSource>();
        note[54] = GameObject.Find("n54").GetComponent<AudioSource>(); */

    }
	
	// Update is called once per frame
	void Update () {
        if (playedNoteText != null && playedNote!=ActiveNote.activeNote)
        {
            canSpawn = true;
            // display value of note played
            playedNoteText.text = playedNote.ToString();

            // play the sound
            switch ((int)playedNote)
            {
                case 30: n30.Play(d); Spawn(playedNote); break;
                case 31: n31.Play(d); Spawn(playedNote); break;
                case 32: n32.Play(d); Spawn(playedNote); break;
                case 33: n33.Play(d); Spawn(playedNote); break;
                case 34: n34.Play(d); Spawn(playedNote); break;
                case 35: n35.Play(d); Spawn(playedNote); break;
                case 36: n36.Play(d); Spawn(playedNote); break;
                case 37: n37.Play(d); Spawn(playedNote); break;
                case 38: n38.Play(d); Spawn(playedNote); break;
                case 39: n39.Play(d); Spawn(playedNote); break;
                case 40: n40.Play(d); Spawn(playedNote); break;
                case 41: n41.Play(d); Spawn(playedNote); break;
                case 42: n42.Play(d); Spawn(playedNote); break;
                case 43: n43.Play(d); Spawn(playedNote); break;
                case 44: n44.Play(d); Spawn(playedNote); break;
                case 45: n45.Play(d); Spawn(playedNote); break;
                case 46: n46.Play(d); Spawn(playedNote); break;
                case 47: n47.Play(d); Spawn(playedNote); break;
                case 48: n48.Play(d); Spawn(playedNote); break;
                case 49: n49.Play(d); Spawn(playedNote); break;
                case 50: n50.Play(d); Spawn(playedNote); break;
                case 51: n51.Play(d); Spawn(playedNote); break;
                case 52: n52.Play(d); Spawn(playedNote); break;
                case 53: n53.Play(d); Spawn(playedNote); break;
                case 54: n54.Play(d); Spawn(playedNote); break;
                case 55: n55.Play(d); Spawn(playedNote); break;
                case 56: n56.Play(d); Spawn(playedNote); break;
                case 57: n57.Play(d); Spawn(playedNote); break;
                case 58: n58.Play(d); Spawn(playedNote); break;
                case 59: n59.Play(d); Spawn(playedNote); break;
                case 60: n60.Play(d); Spawn(playedNote); break;
                case 61: n61.Play(d); Spawn(playedNote); break;
                case 62: n62.Play(d); Spawn(playedNote); break;
                case 63: n63.Play(d); Spawn(playedNote); break;
                case 64: n64.Play(d); Spawn(playedNote); break;
                case 65: n65.Play(d); Spawn(playedNote); break;
                case 66: n66.Play(d); Spawn(playedNote); break;
                case 67: n67.Play(d); Spawn(playedNote); break;
                case 68: n68.Play(d); Spawn(playedNote); break;
                case 69: n69.Play(d); Spawn(playedNote); break;
            }
        }
    }

    void Spawn(double? playedNote)
    {
        if (canSpawn)
        {
            // create asset at y value proportionate to note
            float pitch = (float)PlayedNote.playedNote / 5 - 7;
            Vector3 spawnPos = new Vector3(10.2f, pitch);
            Instantiate(noteSphere, spawnPos, Quaternion.identity);
            noteSphere.GetComponent<Rigidbody>().velocity = new Vector3(-.01f, 0);
            canSpawn = false;

            // populate log for csv file
            string[] note = new string[2];
            time = (int)(Time.time*24);
            note[0] = time.ToString();
            played = (int)playedNote;
            note[1] = played.ToString();
            log.Add(note);


        }
    }
}
