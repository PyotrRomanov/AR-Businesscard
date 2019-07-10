using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PrismAnimationScript : MonoBehaviour
{
    public bool prismVisible;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPrism(){
        if (!prismVisible)
        {
            prismVisible = true;
            transform.DOLocalMoveY(-0.318f, 1);
            AnalyticsScript.OpenedPrism();
        }
        else
        {
            prismVisible = false;
            transform.DOLocalMoveY(-1.04f, 1);
            AnalyticsScript.ClosedPrism();
        }
    }

    public void HidePrism(){
        if (prismVisible)
        {
            prismVisible = false;
            transform.DOLocalMoveY(-1.04f, 1);
            AnalyticsScript.ClosedPrism();
        }
    }


}
