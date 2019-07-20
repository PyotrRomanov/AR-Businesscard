using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HeadedListAnimator : MonoBehaviour
{
    [SerializeField]
    AnimationCurve bump;

    [SerializeField]
    float dir = 1;

    List<RectTransform> children;

    // Start is called before the first frame update
    void Start()
    {
        children = new List<RectTransform>();

        transform.localPosition = new Vector3(0, 0.233f, 0);

        for(int i = 0; i < transform.childCount; i++){
            RectTransform child = (RectTransform)transform.GetChild(i);
            children.Add(child);
        }

        for(int i = 0; i < children.Count; i++){
            children[i].localPosition = new Vector3(children[i].localPosition.x, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimateHeadedList(){
        StartCoroutine(AnimateHeadedListCoroutine());
    }

    IEnumerator AnimateHeadedListCoroutine(){
        transform.DOLocalMoveX(1.033f * dir, 1f).SetEase(bump);
        yield return new WaitForSeconds(1f);
        for(int i = 0; i < children.Count - 1; i++){
            children[i].DOLocalMoveY(-0.214f * (i + 1), 1f).SetEase(bump).SetDelay((children.Count - 1 - i) * 0.3f);
        }
    }

    public void UnAnimateHeadedList(){
        StopCoroutine(AnimateHeadedListCoroutine());
        StartCoroutine(UnAnimateHeadedListCoroutine());
    }

    IEnumerator UnAnimateHeadedListCoroutine(){
        for(int i = 0; i < children.Count - 1; i++){
            children[i].DOLocalMoveY(0, 1f).SetEase(bump).SetDelay((children.Count - 1 - i) * 0.3f);
        }

        yield return new WaitForSeconds(1f);
        
        transform.DOLocalMoveX(0, 1f).SetEase(bump);
    }
}
