using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimationAnimationScript : MonoBehaviour
{
    public bool animationVisible;


    [SerializeField]
    AnimationCurve bouncyCurve;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowAnimation()
    {
        if (!animationVisible)
        {
            AnalyticsScript.OpenedAnimation();
            transform.DOLocalMoveZ(0.052f, 1f);
            animationVisible = true;
        }
        else
        {
            HideAnimation();
        }
    }

    public void HideAnimation()
    {
        if (animationVisible)
        {
            animationVisible = false;
            transform.DOLocalMoveZ(0.6f, 1f);
            AnalyticsScript.ClosedAnimation();
        }
    }
}
