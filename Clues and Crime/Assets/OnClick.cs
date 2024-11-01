using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{

    public GameObject BackgroundPanel;
    public GameObject Panel1;
    public GameObject Panel2;

    // Boolean for tracking if background panel is active
    private bool BGActive;

    // Start is called before the first frame update
    void Start()
    {
        BGActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        Debug.Log("Button clicked.");

        // Experimenting with best ways to popup window, scene change, UI layers, etc. -Noah
        if (BGActive)
        {
            BGActive = false;
            BackgroundPanel.SetActive(false); // Hide background panel
            Panel1.SetActive(true); // Show new window panel
        }
        else
        {
            BGActive = true;
            BackgroundPanel.SetActive(true);
            Panel1.SetActive(false);
        }
    }
}
