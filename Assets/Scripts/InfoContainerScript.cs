using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class InfoContainerScript : MonoBehaviour
{
    [SerializeField]
    GameObject skills;

    [SerializeField]
    GameObject other;

    public bool infoVisible;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimateInfo(){
        if(!infoVisible){
            StartCoroutine(AnimateInfoCoroutine());
            infoVisible = true;
        }else{
            StartCoroutine(UnAnimateInfoCoroutine());
        }
    }

    IEnumerator AnimateInfoCoroutine(){
        skills.GetComponent<HeadedListAnimator>().AnimateHeadedList();
        yield return new WaitForSeconds(2f);
        other.GetComponent<HeadedListAnimator>().AnimateHeadedList();
    }

    public void UnAnimateInfo(){
        StartCoroutine(UnAnimateInfoCoroutine());
    }

    IEnumerator UnAnimateInfoCoroutine(){
        other.GetComponent<HeadedListAnimator>().UnAnimateHeadedList();
        yield return new WaitForSeconds(2f);
        skills.GetComponent<HeadedListAnimator>().UnAnimateHeadedList();
        infoVisible = false;
    }
}
