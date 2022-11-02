using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
public class PlayOneShot_StateBehavior : StateMachineBehaviour
{
    public EventReference soundToPlay;

    public bool trackObjectPosition;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        //Readable version:
        if (trackObjectPosition)
        {
            RuntimeManager.PlayOneShot(soundToPlay, animator.GetComponent<Transform>().position);
        }
        else
        {
            RuntimeManager.PlayOneShot(soundToPlay);
        }

        // Coding 'Golf' Version:
        //
        // Vector3 pos = trackObjectPosition ? animator.GetComponent<Transform>().position : default;
        // ''position is equal to: is trackObjectPostion true? Then return the transform position: else return default''
        // RuntimeManager.PlayOneShot(soundToPlay, pos);

        // hole in 1 version:
        // RuntimeManager.PlayOneShot(soundToPlay, trackObjectPosition ? animator.GetComponent<Transform>().position : default)
        
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }
}
