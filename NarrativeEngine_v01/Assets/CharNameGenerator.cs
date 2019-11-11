using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharNameGenerator : MonoBehaviour
{
    //[SerializeField] string[] CharNames; //possibly make male and female names?
    [SerializeField] List<string> CharNames;

    public string GenerateName()
    {
        int r = Random.Range(0, CharNames.Count);
        return CharNames[r];
    }
}