using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class ButtonHandlers : MonoBehaviour
{
    private GameObject UI_Container;
    private GameObject Video1;
    private GameObject Video2;

    public void menuRotateCounterClockwise()
    {
        UI_Container = GameObject.Find("UI Container");
        UI_Container.transform.Rotate(0, -90, 0, Space.World); //rotate relative to world
    }
    public void menuRotateClockwise()
    {
        UI_Container = GameObject.Find("UI Container");
        UI_Container.transform.Rotate(0, 90, 0, Space.World); //rotate relative to world
    }
    public void PlayVideoOne()
    {
        Video1 = GameObject.Find("Video1");
        VideoPlayer player = (VideoPlayer)Video1.GetComponent("VideoPlayer");
        player.Play();
    }

    public void PlayVideoTwo()
    {
        Video2 = GameObject.Find("Video2");
        VideoPlayer player = (VideoPlayer)Video2.GetComponent("VideoPlayer");
        player.Play();
    }
}
