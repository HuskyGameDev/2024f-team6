using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownHandler : MonoBehaviour
{
    public GameObject citizenDisplay, citizenRecords;

    public TMP_Dropdown selectCitizenDropdown;
    public TMP_Text selectCitizenText;

    void Start()
    {
        CitizenData[] citizens = citizenRecords.GetComponent<CitizenGenerator>().citizens;

        selectCitizenDropdown.onValueChanged.AddListener(changeDisplay);
    }

    private void changeDisplay(int index)
    {
        citizenDisplay.GetComponent<CitizenDisplay>().displayData( citizenRecords.GetComponent<CitizenGenerator>().citizens[index] );
    }
}
