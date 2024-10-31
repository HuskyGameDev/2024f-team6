using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenGenerator : MonoBehaviour
{

    // This data needs to be restored, not regenerated after closing and reopening the game
    public CitizenData[] citizens;

    // Constants that determine generated values
    
    int recordsSize = 40;               // MAKE LARGER?



    private string pathFirstnamesM  = "Assets/Citizen/firstnames_M.txt";
    private string pathFirstnamesF  = "Assets/Citizen/firstnames_F.txt";
    private string pathLastnames    = "Assets/Citizen/lastnames.txt";

    private string[] fnamesM, fnamesF, lnames;

    int minFootsize = 8;
    int maxFootsize = 14;
    int minRandomBirthyear = 1944;
    int maxRandomBirthyear = 2008;

    int fingerprints = 10000;


    void createData(CitizenData target)
    {
        target.sex = (Biosex)Random.Range(0,2);
        target.firstname = target.sex == Biosex.M ? fnamesM[Random.Range(0, fnamesM.Length)] : fnamesF[Random.Range(0, fnamesF.Length)];
        target.lastname = lnames[Random.Range(0, lnames.Length)];
        
        target.footsize = Random.Range(minFootsize, maxFootsize);
        target.birthyear = Random.Range(maxRandomBirthyear, minRandomBirthyear);
        
        target.eyeColor = (EyeColor)Random.Range(0, 6);

        target.fingerprintIndex = Random.Range(0, fingerprints);
    }


    void Awake()
    {
  
        // TODO: Only when generating new list?
        fnamesM = System.IO.File.ReadAllLines(pathFirstnamesM);
        fnamesF = System.IO.File.ReadAllLines(pathFirstnamesF);
        lnames = System.IO.File.ReadAllLines(pathLastnames);

        System.Array.Resize(ref citizens, recordsSize);

        for(int i = 0; i < recordsSize; ++i)
        {
            citizens[i] = new CitizenData();
            createData(citizens[i]);
        };

    }


}
