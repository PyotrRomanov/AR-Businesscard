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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimateInfo(){
        StartCoroutine(AnimateInfoCoroutine());
    }

    IEnumerator AnimateInfoCoroutine(){
        skills.GetComponent<HeadedListAnimator>().AnimateHeadedList();
        yield return new WaitForSeconds(2f);
        other.GetComponent<HeadedListAnimator>().AnimateHeadedList();
    }
}
