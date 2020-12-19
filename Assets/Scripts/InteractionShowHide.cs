using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionShowHide : Interaction
{
    public GameObject publicObject = null;
    public TextAsset play_icon;
    public Material material;

    public override void Interact()
    {
        HideOrShowComponent();
    }

    private void HideOrShowComponent()
    {
        publicObject.SetActive(!publicObject.activeSelf);
    }

    public void Start()
    {
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(play_icon.bytes);
        material.mainTexture = texture;
    }
}
