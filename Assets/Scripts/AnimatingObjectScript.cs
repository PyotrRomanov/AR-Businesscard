using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatingObjectScript : DefaultTrackableEventHandler
{
    public Animation moveCanvas;

	// Use this for initialization
	override protected void Start () {
        base.Start();

        Debug.Log("Start of animatingobjectscript");
    }
	
	// Update is called once per frame
	void Update () {
	}
    
    override protected void OnTrackingFound(){
        base.OnTrackingFound();
        moveCanvas.Play();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
    }
}
