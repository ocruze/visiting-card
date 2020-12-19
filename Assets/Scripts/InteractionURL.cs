using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionURL : Interaction
{
    public string url = "http://www.foks-lab.fr";
    public override void Interact()
    {
        Application.OpenURL(url);

    }

    public void Start()
    {
        this.gameObject.SetActive(false);
    }
}
