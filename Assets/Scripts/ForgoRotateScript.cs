using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ForgoRotateScript : MonoBehaviour
{
    [SerializeField]
    AnimationCurve curve;

    [SerializeField]
    float speed = 1f;

    LoudnessDetectionScript loudNessScript;

    [SerializeField]
    GameObject MicRecorder;

    // Start is called before the first frame update
    void Start()
    {
       // RotateForgo();
       loudNessScript = MicRecorder.GetComponent<LoudnessDetectionScript>();
       transform.Rotate(new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, 1);
        float loudnessMultiplier = 1;
        if(loudNessScript.MicLoudness > 0.1f){
            loudnessMultiplier = 10;
        }

        transform.Rotate(direction * speed * Time.deltaTime * loudnessMultiplier, Space.Self);
    }

    public void RotateForgo() {
        transform.DOLocalRotate(new Vector3(0, 360, 0), speed, RotateMode.FastBeyond360).OnComplete(CompleteCallback);
    }

    void CompleteCallback() {
        RotateForgo();
    }
}
