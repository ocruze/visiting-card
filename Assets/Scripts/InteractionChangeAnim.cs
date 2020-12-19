using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionChangeAnim : Interaction
{
    public Animator _animator = null;

    public override void Interact()
    {
        int oldState = _animator.GetInteger("state");
        int maxState = 2;
        int newState;

        if (oldState == maxState)
            newState = 0;
        else
            newState = oldState + 1;

        _animator.SetInteger("state", newState);

        /*
        if (_animator.GetInteger("state") == 0)
            _animator.SetInteger("state", 1);
        else
            _animator.SetInteger("state", 0);
        */
    }
}
