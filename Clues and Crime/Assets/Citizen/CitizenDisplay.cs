using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

// Class to display components of any citizen
public class CitizenDisplay : MonoBehaviour
{

    // Components of the display
    public VideoPlayer videoPlayer;
    public TextMeshProUGUI bioText;

    // Referenced data
    public GameObject recordsReferenced;

    public void displayData(CitizenData citizen)
    {

        bioText.text = "Name: " + citizen.firstname + " " + citizen.lastname    + "\n"
                     + "Age:" + (2024-citizen.birthyear).ToString()             + "\n"
                     + "Sex:" + citizen.sex                                     + "\n"
                     + "Footsize: " + citizen.footsize.ToString()               + "\n"
                     + "Eye color: " + citizen.eyeColor.ToString()              + "\n";


        videoPlayer.frame = citizen.fingerprintIndex;
        
    }

    void Start()
    {
        // Show the first person in records
        displayData(recordsReferenced.GetComponent<CitizenGenerator>().citizens[0]);
    }

}
