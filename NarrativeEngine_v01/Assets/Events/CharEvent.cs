using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharEvent : MonoBehaviour
{
    [SerializeField] private int ReqDrama;
    [SerializeField] private int ReqOpinion;
    [SerializeField]enum EventType { Overcome, Riches, Fetch, Journy, Tragedy, Rebirth };


    [SerializeField] private CharEvent UnlockedEvents;

    public abstract void StartEvent();
    public abstract void EndEvent();
}
