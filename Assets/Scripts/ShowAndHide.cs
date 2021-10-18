using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ShowAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    private int NumButtonPressed = 0;
    //public GameObject Jaipur_Cube;
    //public GameObject Udaipur_Cube;
    public GameObject Ajmer;
    public GameObject Jodhpur;
    public GameObject Bikaner;
    public GameObject Jaisalmer;
    public GameObject Btn;
    public GameObject Jaipur;
    public GameObject Udaipur;
    public GameObject thar_videoplayer;

    void Start()
    {
        thar_videoplayer.SetActive(false);
        thar_videoplayer.GetComponent<VideoPlayer>().Pause();
        //Jaipur_Cube.SetActive(false);
        //Udaipur_Cube.SetActive(false);
        Ajmer.SetActive(false);
        Jodhpur.SetActive(false);
        Bikaner.SetActive(false);
        Jaisalmer.SetActive(false);
        Jaipur.SetActive(false);
        Udaipur.SetActive(false);
    }

    public void ShowHide()
    {
        NumButtonPressed = (NumButtonPressed)%8 + 1;
        if(NumButtonPressed == 1)
        {
            thar_videoplayer.SetActive(false);
            Jaipur.SetActive(true);
            Udaipur.SetActive(false);
            Ajmer.SetActive(false);
            Jodhpur.SetActive(false);
            Bikaner.SetActive(false);
            Jaisalmer.SetActive(false);
            
            Btn.GetComponentInChildren<Text>().text = "Let us next go to 'City of lakes' Udaipur";
        }
        else if (NumButtonPressed == 2)
        {
            thar_videoplayer.SetActive(false);
            Jaipur.SetActive(false);
            Udaipur.SetActive(true);
            Ajmer.SetActive(false);
            Jodhpur.SetActive(false);
            Bikaner.SetActive(false);
            Jaisalmer.SetActive(false);
            
            Btn.GetComponentInChildren<Text>().text = "Next Spot:Flora Fauna of Ajmer";
        }
        else if (NumButtonPressed == 3)
        {
            thar_videoplayer.SetActive(false);
            Jaipur.SetActive(false);
            Udaipur.SetActive(false);
            Ajmer.SetActive(true);
            Jodhpur.SetActive(false);
            Bikaner.SetActive(false);
            Jaisalmer.SetActive(false);
            
            Btn.GetComponentInChildren<Text>().text = "Let us Next Visit 'SunCity' Jodhpur ";
        }
        else if (NumButtonPressed == 4)
        {
            thar_videoplayer.SetActive(false);
            Jaipur.SetActive(false);
            Udaipur.SetActive(false);
            Ajmer.SetActive(false);
            Jodhpur.SetActive(true);
            Bikaner.SetActive(false);
            Jaisalmer.SetActive(false);
            
            Btn.GetComponentInChildren<Text>().text = "Next Destination:Bikaner Known as 'Camel Country'";
        }
        else if (NumButtonPressed == 5)
        {
            thar_videoplayer.SetActive(false);
            Jaipur.SetActive(false);
            Udaipur.SetActive(false);
            Ajmer.SetActive(false);
            Jodhpur.SetActive(false);
            Bikaner.SetActive(true);
            Jaisalmer.SetActive(false);
            
            Btn.GetComponentInChildren<Text>().text = "Last Spot 'Golden City' Jaisalmer";
        }
        else if (NumButtonPressed == 6)
        {
            thar_videoplayer.SetActive(false);
            Jaipur.SetActive(false);
            Udaipur.SetActive(false);
            Ajmer.SetActive(false);
            Jodhpur.SetActive(false);
            Bikaner.SetActive(false);
            Jaisalmer.SetActive(true);
            
            Btn.GetComponentInChildren<Text>().text = "Have A look at a Video of Flora and fauna of Thar Desert";
        }
        else if(NumButtonPressed==7)
        {
            thar_videoplayer.SetActive(true);
            thar_videoplayer.GetComponent<VideoPlayer>().Play();
            Jaipur.SetActive(false);
            Udaipur.SetActive(false);
            Ajmer.SetActive(false);
            Jodhpur.SetActive(false);
            Bikaner.SetActive(false);
            Jaisalmer.SetActive(false);
            Btn.GetComponentInChildren<Text>().text = "End Tour";
        }
        else if(NumButtonPressed == 8)
        {
            thar_videoplayer.SetActive(false);
            thar_videoplayer.GetComponent<VideoPlayer>().Pause();
            Jaipur.SetActive(false);
            Udaipur.SetActive(false);
            Ajmer.SetActive(false);
            Jodhpur.SetActive(false);
            Bikaner.SetActive(false);
            Jaisalmer.SetActive(false);
            Btn.GetComponentInChildren<Text>().text = "Welcome to 'Pink City' Jaipur";
        }
    }
}
