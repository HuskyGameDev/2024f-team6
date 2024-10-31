using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Characteristics of an individual citizen
public class CitizenData
{
    // Textual biometrics
    public string firstname;
    public string lastname;

    public EyeColor eyeColor;
    public Biosex sex;

    public int birthyear;
    public int footsize;                   

    // Image biometrics
    public int fingerprintIndex;            // A random number in some large range that corresponds to the n-th frame in the fingerprint video
    public byte[] dna_code;                 // The dna image will be split into 64 zones each painted blue (no match) or orange (match) match occurs when A[i] == B[i] for citizens A, B

    public byte[] face_gen;                 // Components of the profile picture, should one be added

    public CitizenData()
    {
        firstname = "John";
        lastname = "Doe";
        birthyear = 1984;
        footsize = 11;
        eyeColor = EyeColor.brown;
        sex = Biosex.M;
        fingerprintIndex = 88;
        dna_code = new byte[64];
    }

}
