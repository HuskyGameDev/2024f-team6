using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{

    public GameObject onClickWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        Debug.Log("Button clicked.");

        // Experimenting with best ways to popup window, scene change, UI layers, etc. -Noah
        // onClickWindow.SetActive(true); // One way to hide/show UI elements
    }
}
