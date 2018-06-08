using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System;
using System.Linq;

public class CSVManager : MonoBehaviour {

    public List<int[]> input = new List<int[]>();
    public int t = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Back"))
        {
            SaveToFile(PlayedNote.log);
        }
        if (Input.GetButtonDown("Start"))
        {
            ReadFromCreated();
        }
        PlayInput();
	}

    public void SaveToFile(List<string[]> log)
    {
        string[][] output = new string[log.Count][];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = log[i];
        }

        int length = output.GetLength(0);
        string delimiter = ",";

        StringBuilder sb = new StringBuilder();

        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));

        string filePath = "C:/Users/Hovanes/Desktop/UCR/Project/UCG/ucg1.csv";

        StreamWriter outStream = System.IO.File.AppendText(filePath);
        outStream.WriteLine(sb);
        outStream.Close();
    }

    public void ReadFromCreated()
    {
        string filePath = "C:/Users/Hovanes/Desktop/UCR/Project/createdsong.csv";
        StreamReader reader = new StreamReader(@filePath);

        string s = reader.ReadLine();
        int result;

        while (s != null)
        {
            string[] values = s.Split(',');
            int[] line = new int[2];
            if (Int32.TryParse(values[1], out result)) { line[0] = result; } else { line[0] = 0; };
            if (Int32.TryParse(values[4], out result)) { line[1] = result; } else { line[1] = 0; };
            if (Int32.TryParse(values[5], out result)) { if (result > 0) { input.Add(line); } };
        }     
    }

    public void PlayInput()
    {
        // sort by time ?
        for (int i = 0; i < input.Count; i++) {
            if (input[i][0] >= t && input[i][0] < t + 3)
            {
                PlayedNote.playedNote = input[i][1];
                t += 3;
            }
        }
    }
}
