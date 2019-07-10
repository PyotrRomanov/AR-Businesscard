using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using DG.Tweening;

public class VideoAnimationScript : MonoBehaviour
{

    public bool videoVisible;
    [SerializeField]
    VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowVideo()
    {
        if (!videoVisible)
        {
            videoVisible = true;
            videoPlayer.time = 0;
            videoPlayer.Play();
            transform.DOLocalMoveZ(-0.047f, 1);
            AnalyticsScript.OpenedVideo();
        }
        else
        {
            videoVisible = false;
            transform.DOLocalMoveZ(0.013f, 0.4f);
            AnalyticsScript.ClosedVideo();
        }
    }

    public void HideVideo()
    {
        if (videoVisible)
        {
            videoVisible = false;
            transform.DOLocalMoveZ(0.013f, 0.4f);
            AnalyticsScript.ClosedVideo();
        }
    }
}
