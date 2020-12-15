using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionShowHide : Interaction
{
    public GameObject publicObject = null;

    public override void Interact()
    {
        HideOrShowComponent();
    }

    private void HideOrShowComponent()
    {
        publicObject.SetActive(!publicObject.activeSelf);
    }
}
