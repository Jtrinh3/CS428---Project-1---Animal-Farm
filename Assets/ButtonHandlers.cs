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
    private int reviewNum = 1;
    private static int TOTAL_REVIEWS = 2;



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

    public void prevReview()
    {
        if (reviewNum == 1)
        {
            reviewNum = TOTAL_REVIEWS;
        }
        else
        {
            reviewNum = reviewNum - 1;
        }

        changeReview(reviewNum);



    }

    public void nextReview()
    {
        if(reviewNum == TOTAL_REVIEWS)
        {
            reviewNum = 1;
        }
        else
        {
            reviewNum = reviewNum + 1;
        }
        changeReview(reviewNum);

    }

    public void changeReview(int reviewNumber)
    {
    GameObject author = GameObject.Find("Author Text");

        author.GetComponent<UnityEngine.UI.Text>().text = "Debbie D.";
        GameObject review = GameObject.Find("Review Text");

        review.GetComponent<UnityEngine.UI.Text>().text = "Animal farm is a great book that plays around with many themes. I hope one day my kids grow up to be a strong leader like Napoleon.";
        starChange(2);
       
    }

    public void starChange(int stars)
    {
        Material gold = Resources.Load("Gold Star", typeof(Material)) as Material;
        Material black = Resources.Load("Black Star", typeof(Material)) as Material;

        GameObject star1 = GameObject.Find("star1");
        GameObject star2 = GameObject.Find("star2");
        GameObject star3 = GameObject.Find("star3");
        GameObject star4 = GameObject.Find("star4");
        GameObject star5 = GameObject.Find("star5");

        switch (stars)
        {
            case 0:
                star1.GetComponentInChildren<MeshRenderer>().material = black;
                star2.GetComponentInChildren<MeshRenderer>().material = black;
                star3.GetComponentInChildren<MeshRenderer>().material = black;
                star4.GetComponentInChildren<MeshRenderer>().material = black;
                star5.GetComponentInChildren<MeshRenderer>().material = black;
                break;
            case 1:
                star1.GetComponentInChildren<MeshRenderer>().material = gold;
                star2.GetComponentInChildren<MeshRenderer>().material = black;
                star3.GetComponentInChildren<MeshRenderer>().material = black;
                star4.GetComponentInChildren<MeshRenderer>().material = black;
                star5.GetComponentInChildren<MeshRenderer>().material = black;
                break;
            case 2:
                star1.GetComponentInChildren<MeshRenderer>().material = gold;
                star2.GetComponentInChildren<MeshRenderer>().material = gold;
                star3.GetComponentInChildren<MeshRenderer>().material = black;
                star4.GetComponentInChildren<MeshRenderer>().material = black;
                star5.GetComponentInChildren<MeshRenderer>().material = black;
                break;
            case 3:
                star1.GetComponentInChildren<MeshRenderer>().material = gold;
                star2.GetComponentInChildren<MeshRenderer>().material = gold;
                star3.GetComponentInChildren<MeshRenderer>().material = gold;
                star4.GetComponentInChildren<MeshRenderer>().material = black;
                star5.GetComponentInChildren<MeshRenderer>().material = black;
                break;
            case 4:
                star1.GetComponentInChildren<MeshRenderer>().material = gold;
                star2.GetComponentInChildren<MeshRenderer>().material = gold;
                star3.GetComponentInChildren<MeshRenderer>().material = gold;
                star4.GetComponentInChildren<MeshRenderer>().material = gold;
                star5.GetComponentInChildren<MeshRenderer>().material = black;
                break;
            case 5:
                star1.GetComponentInChildren<MeshRenderer>().material = gold;
                star2.GetComponentInChildren<MeshRenderer>().material = gold;
                star3.GetComponentInChildren<MeshRenderer>().material = gold;
                star4.GetComponentInChildren<MeshRenderer>().material = gold;
                star5.GetComponentInChildren<MeshRenderer>().material = gold;
                break;
            

        }
    }

}
