using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTrait : MonoBehaviour
{
    [SerializeField] string TraitName;

    [Tooltip("0=opinion, 1=Str, 2=Agi, 3=Int, 4=Char, 5=Cun")]
    [SerializeField] int[] EffectedStats; //Write in the number of the stat it effects

    /*[Tooltip("0 = opinion, 1 = Str, 2 = Agi, 3 = Int, 4 = Char, 5 = Cun")]
    [SerializeField] int[] Values; //write the amount in which the effected stat changes*/

    public string GetTraitName()
    { return TraitName; }

    public int[] GetTraitEffectedStats()
    { return EffectedStats; }

    /*public int[] GetTraitValues()
    { return EffectedStats; }*/
}
