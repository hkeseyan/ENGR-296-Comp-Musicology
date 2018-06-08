using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_input : MonoBehaviour {

    public bool isButton = true;
    public bool leftJoystick = false;
    public bool rightJoystick = false;
    public bool dPad = false;
    public bool triggers = false;
    public string buttonName;

    private Vector3 startPos;
    private Transform thisTransform;
    private MeshRenderer mr;

    public Color restColor = new Color(0.1F, 0.1F, 0.7F, 0.8F);
    public Color activeColor = new Color(0.7F, 0.1F, 0.1F, 0.2F);

    public float restR2;
    public float restL2;

    // Use this for initialization
    void Start () {
        thisTransform = transform;
        startPos = thisTransform.position;
        mr = thisTransform.GetComponent<MeshRenderer>();
        mr.material.color = restColor;
        //restR2 = Input.GetAxis("R2");
       // restL2 = Input.GetAxis("L2");
}
	
	// Update is called once per frame
	void Update () {
        if (isButton)
        {
            if (triggers)
            {
                bool triggerPulled = false;
                /*if (Input.GetAxis("R2") == 0)
                {
                    triggerPulled = true;
                    mr.enabled = triggerPulled;
                    mr.material.color = activeColor;
                }*/
                if (Input.GetAxis("L2") < 0 || Input.GetAxis("R2") < 0)
                {
                    triggerPulled = true;
                    mr.enabled = triggerPulled;
                    mr.material.color = activeColor;
                }
                else
                {
                    mr.enabled = true;
                    mr.material.color = restColor;
                }
            }
            else
            {
                mr.enabled = Input.GetButton(buttonName);
                if (mr.enabled)
                {
                    mr.material.color = activeColor;
                }
                else if (!leftJoystick && !rightJoystick)
                {
                    mr.enabled = true;
                    mr.material.color = restColor;
                }
            }

        }
        else
        {
            if (leftJoystick)
            {
                Vector3 inputDirection = Vector3.zero;
                inputDirection.x = Input.GetAxis("Lx");
                inputDirection.y = -Input.GetAxis("Ly");
                thisTransform.position = startPos + inputDirection;
            }
            else if (rightJoystick)
            {
                Vector3 inputDirection = Vector3.zero;
                inputDirection.x = Input.GetAxis("Rx");
                inputDirection.y = -Input.GetAxis("Ry");
                thisTransform.position = startPos + inputDirection;
            }
            else if (dPad)
            {
                Vector3 inputDirection = Vector3.zero;
                inputDirection.x = Input.GetAxis("Dx");
                inputDirection.y = Input.GetAxis("Dy");
                thisTransform.position = startPos + 0.2F * inputDirection;
            }
            else if (triggers)
            {
                Vector3 inputDirection = Vector3.zero;
                inputDirection.x = Input.GetAxis("Triggers");
                thisTransform.position = startPos + inputDirection;
            }
        }
	}
}
