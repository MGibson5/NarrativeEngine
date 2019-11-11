using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharGenerator : MonoBehaviour
{
    int age;
    string role; 

    // Start is called before the first frame update
    void Start()
    {
        //gen Age
        age = Random.Range(18, 118);

        
    }

    private void GenerateRole()
    {
        //gen Role
        int r_ = Random.Range(0, 5);
        if (r_ == 0)
            role = ("peasent");
        else if (r_ == 1)
            role = ("farmer");
    }

}
