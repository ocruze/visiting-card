using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterationScale : Interaction
{
    public GameObject bonhommeCube;
    public GameObject bonhomme;
    public GameObject particules;
    public float scalingTime = 3f;
    private bool isScaling = false;
    private int state = 1;

    public override void Interact()
    {

        if (state == 0)
        {
            StartCoroutine(ScaleOpen());
        }
        else
        {
            StartCoroutine(ScaleClose());
        }
    }

    private IEnumerator ScaleClose()
    {
        //Make sure there is only one instance of this function running
        if (isScaling)
        {
            yield break; ///exit if this is still running
        }
        isScaling = true;

        bonhomme.SetActive(false);
        particules.SetActive(false);

        Transform transform = bonhommeCube.transform;
        Vector3 toScale = new Vector3(0.1f, 0.001f, 0.005f);
        yield return ScaleOverTime(transform, toScale, scalingTime);
            state = 0;
    }

    private IEnumerator ScaleOpen()
    { 
        //Make sure there is only one instance of this function running
        if (isScaling)
        {
            yield break; ///exit if this is still running
        }
        isScaling = true;

        Transform transform = bonhommeCube.transform;
        Vector3 toScale = new Vector3(0.1f, 0.05f, 0.005f); 
        yield return ScaleOverTime(transform, toScale, scalingTime);

        bonhomme.SetActive(true);
        particules.SetActive(true);
        state = 1;
    }

    IEnumerator ScaleOverTime(Transform objectToScale,Vector3 toScale, float duration)
    {
        float counter = 0;

        //Get the current scale of the object to be moved
        Vector3 startScaleSize = objectToScale.localScale;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            objectToScale.localScale = Vector3.Lerp(startScaleSize, toScale, counter / duration);
            yield return null;
        }

        isScaling = false;
    }
}
