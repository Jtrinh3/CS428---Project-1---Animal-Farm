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
    private static int TOTAL_REVIEWS = 4;

    private bool spokePerson = false;
    private GameObject spokePig;
    // Adjust the speed for the application.
    private float speed = 300f;

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


    public void nextReview()
    {
        reviewNum = reviewNum + 1;
        if (reviewNum == TOTAL_REVIEWS+1)
        {
            reviewNum = 1;
        }
        changeReview(reviewNum);

    }

    public void changeReview(int reviewNumber)
    {
        GameObject author = GameObject.Find("Author Text");
        GameObject review = GameObject.Find("Review Text");


        switch (reviewNumber)
        {
            case 1:
                author.GetComponent<UnityEngine.UI.Text>().text = "Debbie Davis        7/25/18";
                review.GetComponent<UnityEngine.UI.Text>().text = "Animal farm is a great book that plays around with many themes. I hope one day my kids grow up to be a strong leader like Napoleon.";
                starChange(5);
                break;
            case 2:
                author.GetComponent<UnityEngine.UI.Text>().text = "Johann Ashley        1/14/15";
                review.GetComponent<UnityEngine.UI.Text>().text = "I taught a class of high school students with this book and they were all very engage! The book covers many themes and topics that applies even today!";
                starChange(4);
                break;
            case 3:
                author.GetComponent<UnityEngine.UI.Text>().text = "Christian Younglove        8/03/19";
                review.GetComponent<UnityEngine.UI.Text>().text = "I hate this book for many reasons. The largest being it told through third person limited gave it no emotion where emotion could really connect you to the story and make it actually a mildly entertaining book.";
                starChange(1);
                break;
            case 4:
                author.GetComponent<UnityEngine.UI.Text>().text = "Tyler Peck        12/29/18";
                review.GetComponent<UnityEngine.UI.Text>().text = "This was required reading when I was in high school in '63. Seemed like fantasy back then. I can't say that I understood back then the point Mr.Orwell making. So many years later I think I do and I can see that they have actually become reality. Scares the heck out of me. Almost as though Mr. Orwell could see the future.";
                starChange(5);
                break;

        }
       
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

    public void SpokePerson() //moves pig into view
    {
        spokePerson = true;
        spokePig = GameObject.Find("Napoleon Group");
        spokePig.transform.localPosition = new Vector3( 0, 0, 0 );
        StartCoroutine(ExecuteAfterTime(15)); //delay execution 
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        spokePig.transform.localPosition = new Vector3( 0, 5, 0 );
        spokePerson = false;
    }

}
