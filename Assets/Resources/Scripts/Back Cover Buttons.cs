﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//https://docs.unity3d.com/ScriptReference/Transform.Rotate.html
//https://docs.unity3d.com/ScriptReference/GameObject.Find.html

public class ButtonTest : MonoBehaviour
{
    private GameObject UI_Container;
    public void menuRotateCounterClockwise()
    {
        UI_Container = GameObject.Find("UI Container");
        UI_Container.transform.Rotate(0, -90, 0, Space.World); //rotate relative to world
    }
    public void menuRotateClockwise()
    {
        UI_Container = GameObject.Find("UI Container");
        UI_Container.transform.Rotate(0, -90, 0, Space.World); //rotate relative to world
    }
}
