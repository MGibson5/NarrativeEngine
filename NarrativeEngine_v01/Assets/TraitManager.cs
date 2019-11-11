using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraitManager : MonoBehaviour
{
    [SerializeField] BaseTrait[] Traits;

    public BaseTrait GetRandomTrait()
    {
        int r = Random.Range(0, Traits.Length);
        return Traits[r];
    }
}
