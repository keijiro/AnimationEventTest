using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour
{
    void FireEvent(AnimationEvent ev)
    {
        Debug.Log("state:" + ev.animatorStateInfo.shortNameHash + ", clip:" + ev.animatorClipInfo.clip.name);
    }
}
