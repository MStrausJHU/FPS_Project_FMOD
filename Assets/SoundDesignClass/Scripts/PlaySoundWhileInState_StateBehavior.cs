using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;
using FMODUnity;

public class PlaySoundWhileInState_StateBehavior : StateMachineBehaviour
{
    public EventReference soundToPlay;


    private EventInstance instance;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        instance = RuntimeManager.CreateInstance(soundToPlay);
        instance.set3DAttributes(RuntimeUtils.To3DAttributes(animator.transform.position));
        instance.start();

    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        instance.release();
        base.OnStateExit(animator, stateInfo, layerIndex);
    }
}
