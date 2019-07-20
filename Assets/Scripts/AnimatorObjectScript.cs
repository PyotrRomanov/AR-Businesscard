﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using DG.Tweening;

public class AnimatorObjectScript : DefaultTrackableEventHandler
{
    Animator animator;
    bool firstFind = true;
    float timer = -1;
    bool prismVisible = false;
    bool videoVisible = false;
    bool animationVisible = false;

    [SerializeField]
    RectTransform infoButton;

    [SerializeField]
    RectTransform videoButton;
    [SerializeField]
    RectTransform animationButton;

    [SerializeField]
    AnimationCurve bouncyCurve;

    [SerializeField]
    VideoPlayer videoPlayer;

    [SerializeField]
    Transform fonky;
    [SerializeField]
    Transform video;

    [SerializeField]
    GameObject scannedEffect;

    [SerializeField]
    GameObject infoContainer;



    // Use this for initialization
    override protected void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0){
            timer -= Time.deltaTime;
        }
        if(timer > -1 && timer < 0){
            timer = -1;
            AnalyticsScript.LostPermanently();
            StartCoroutine(HideButtons());
            firstFind = true;
        }
    }

    override protected void OnTrackingFound()
    {
        base.OnTrackingFound();
        timer = -1;
        //moveNameAnimator.StartPlayback();
        //animator.playbackTime = 0;
        //animator.time
        if(firstFind)
        {
            AnalyticsScript.FirstDetection();
            firstFind = false;
            scannedEffect.GetComponent<ScannedEffect>().AnimateScannedEffect();
            StartCoroutine(ShowButtons());

        }

    }

    IEnumerator ShowButtons(){
        yield return new WaitForSeconds(1.5f);
        infoButton.DOLocalMoveY(-700f, 1).SetEase(bouncyCurve);
        yield return new WaitForSeconds(0.5f);
        videoButton.DOLocalMoveY(-700f, 1).SetEase(bouncyCurve);
        yield return new WaitForSeconds(0.5f);
        animationButton.DOLocalMoveY(-700f, 1).SetEase(bouncyCurve);
    }

    IEnumerator HideButtons()
    {
        videoButton.DOLocalMoveY(-290.99f, 0.1f).SetEase(bouncyCurve);
        animationButton.DOLocalMoveY(-290.99f, 0.1f).SetEase(bouncyCurve);
        firstFind = false;
        yield return null;
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        timer = 10;

    }

    public void InfoButtonPressed(){

        infoContainer.GetComponent<InfoContainerScript>().AnimateInfo();

        video.GetComponent<VideoAnimationScript>().HideVideo();

        fonky.GetComponent<AnimationAnimationScript>().HideAnimation();

    }


    public void VideoButtonPressed()
    {
        fonky.GetComponent<AnimationAnimationScript>().HideAnimation();

        video.GetComponent<VideoAnimationScript>().ShowVideo();

        infoContainer.GetComponent<InfoContainerScript>().UnAnimateInfo();
    }

    public void AnimationButtonPressed()
    {
        video.GetComponent<VideoAnimationScript>().HideVideo();

        fonky.GetComponent<AnimationAnimationScript>().ShowAnimation();

        infoContainer.GetComponent<InfoContainerScript>().UnAnimateInfo();

    }

}
