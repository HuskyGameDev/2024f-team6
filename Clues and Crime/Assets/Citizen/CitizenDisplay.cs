using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

// Class to display components of any citizen
public class CitizenDisplay : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public CitizenData citizenToDisplay;
    public TextMeshProUGUI bioText;

    public TMP_Dropdown dropdown;

    // Testing vars only
    public int frameShown = 77;     // For testing fingerprints display. REMOVE

    public GameObject recordsReferenced;
    CitizenData[] records;

    public void displayData(CitizenData citizen)
    {

        bioText.text = "Name: " + citizen.firstname + " " + citizen.lastname    + "\n"
                     + "Age:" + (2024-citizen.birthyear).ToString()             + "\n"
                     + "Sex:" + citizen.sex                                     + "\n"
                     + "Footsize: " + citizen.footsize.ToString()               + "\n"
                     + "Eye color: " + citizen.eyeColor.ToString()              + "\n";


        videoPlayer.frame = citizen.fingerprintIndex;

    }

    void HandleInputData(int val)
    {
        displayData(records[val]);
    }

    void Start()
    {
        records = recordsReferenced.GetComponent<CitizenGenerator>().citizens;

        for (int i = 0; i < records.Length; ++i)
        { 
           
        }


        //CitizenData someCitizen = new CitizenData();

        displayData(records[0]);
        // videoPlayer.frame = frameShown; // For testing fingerprints display. REMOVE
    }

}
