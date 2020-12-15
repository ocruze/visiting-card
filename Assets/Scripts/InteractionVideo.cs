using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class InteractionVideo : Interaction
{
    public VideoPlayer videoPlayer = null;
    public override void Interact()
    {
        PlayOrPauseVideo();
    }

    public void Start()
    {
        this.gameObject.SetActive(false);
    }

    private void PlayOrPauseVideo()
    {
        if (videoPlayer.isPlaying)
            videoPlayer.Pause();
        else
            videoPlayer.Play();
    }
}
