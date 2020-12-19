using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterationOpenCloseMenu : Interaction
{
    public TextAsset minus_icon;
    public TextAsset plus_icon;
    public Material material;
    public GameObject[] btns;
    private int state = 0;
    private Texture2D minus_texture;
    private Texture2D plus_texture;

    public override void Interact()
    {
        if (state == 0)
        {
            StartCoroutine(OpenMenu());
            state = 1;
        }
        else
        {
            StartCoroutine(CloseMenu());
            state = 0;
        }
    }

    private IEnumerator CloseMenu()
    {
        for (int i = btns.Length-1; i >= 0; i--)
        {
            btns[i].SetActive(false);
            yield return new WaitForSeconds(0.2f);
        }
        material.mainTexture = plus_texture;
    }

    private IEnumerator OpenMenu()
    {
        foreach (GameObject obj in btns)
        {
            obj.SetActive(true);
            yield return new WaitForSeconds(0.2f);
        }
        material.mainTexture = minus_texture;
    }

    // Start is called before the first frame update
    void Start()
    {
        minus_texture = new Texture2D(2, 2);
        plus_texture = new Texture2D(2, 2);

        minus_texture.LoadImage(minus_icon.bytes);
        plus_texture.LoadImage(plus_icon.bytes);

        material.mainTexture = plus_texture;
    }
}
