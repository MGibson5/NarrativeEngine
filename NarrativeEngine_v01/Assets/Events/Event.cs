using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Event : MonoBehaviour
{
    [SerializeField]private int DramaReqMin = 0; //not neceserly how dramatic it is more of when it occurs in drama structure
    [SerializeField]private int DramaReqMax = 0; //not neceserly how dramatic it is more of when it occurs in drama structure

    [SerializeField]private int EventType = 0; //0 = not set, 1 = combat, 2 = magic, 3 = charisma, 4 = gold, 5 = special

    public void ChangeDramaRequirmentMin(int _changeBy)
    {
        DramaReqMin += _changeBy;
    }

    public void ChangeDramaRequirmentMax(int _changeBy)
    {
        DramaReqMax += _changeBy;
    }

    public int GetDramaRequrementMin()
    {
        return DramaReqMin;
    }
    public int GetDramaRequrementMax()
    {
        return DramaReqMax;
    }

    public abstract void EventStart();

    public abstract void EventEnd();

    public abstract void EventRequrmentsStart();

}
