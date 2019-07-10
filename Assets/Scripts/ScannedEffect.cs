using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScannedEffect : MonoBehaviour
{

    
    [SerializeField]
    GameObject scroller1;

    [SerializeField]
    GameObject scroller2;

    [SerializeField]
    GameObject blinker;

    [SerializeField]
    AnimationCurve blink;

    [SerializeField]
    float blinkDuration = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        blinker.GetComponent<Renderer>().material.color = new Vector4(1, 1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimateScannedEffect(){
        StartCoroutine(AnimateScannedEffectCoroutine());
    }

    IEnumerator AnimateScannedEffectCoroutine(){
        scroller1.GetComponent<ScrollerScript>().AnimateScroller();
        scroller2.GetComponent<ScrollerScript>().AnimateScroller();
        yield return new WaitForSeconds(1);
        blinker.GetComponent<Renderer>().material.DOFade(1, blinkDuration).SetEase(blink);
    }
}
