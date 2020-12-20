using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionChangeAnim : Interaction
{
    public GameObject bonhomme = null;

    public override void Interact()
    {
        int oldState = bonhomme.GetComponent<Animator>().GetInteger("state");
        int maxState = 2;
        int newState;

        if (oldState == maxState)
            newState = 0;
        else
            newState = oldState + 1;

        bonhomme.GetComponent<Animator>().SetInteger("state", newState);
    }
}
