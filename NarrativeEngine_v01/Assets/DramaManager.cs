using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DramaManager : MonoBehaviour
{
    [SerializeField]private int CurrentDrama;
    [SerializeField] private int NextDramaThreshold;

    [SerializeField] private Event[] Events;
    [SerializeField] private Event[] CompletedEvents;

    [SerializeField] private Event[] CharEvents;
    [SerializeField] private Event[] CompletedCharEvents;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeDrama(int _changeBy)
    {
        CurrentDrama += 1;
    }

    public int GetDrama()
    {
        return CurrentDrama;
    }
}
