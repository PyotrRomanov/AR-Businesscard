using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScrollerScript : MonoBehaviour
{

    [SerializeField]
    float growDuration = 0.3f;

    [SerializeField]
    float dir = 1;

    [SerializeField]
    AnimationCurve growEase;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimateScroller(){
        Debug.Log("animatescroller");
        StartCoroutine(AnimateScrollerRoutine());
    }

    IEnumerator AnimateScrollerRoutine(){
        transform.DOScaleZ(1, growDuration).SetEase(growEase);
        yield return new WaitForSeconds(growDuration);
        transform.DOLocalMoveX(0.484f * dir, 0.7f).SetEase(growEase);
    }
}
