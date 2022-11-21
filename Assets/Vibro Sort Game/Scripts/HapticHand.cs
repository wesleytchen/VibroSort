using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticHand : MonoBehaviour
{

    public HapticsManager hM;
    public OVRInput.Controller controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Haptic")) {
            HapticInteractable currentHapticObject = other.gameObject.GetComponent<HapticInteractable>();
            if (controller == OVRInput.Controller.LTouch) {
                hM.LeftHapticsBuffer_amp = currentHapticObject.GetHapticBufferAmplitudes();
                hM.LeftHapticsBuffer_freq = currentHapticObject.GetHapticBufferFrequencies();
                hM.leftHapticLoop = currentHapticObject.GetIsLoopable();
                hM.leftHapticStartTime = Time.time;
            } else if (controller == OVRInput.Controller.RTouch) {
                hM.RightHapticsBuffer_amp = currentHapticObject.GetHapticBufferAmplitudes();
                hM.RightHapticsBuffer_freq = currentHapticObject.GetHapticBufferFrequencies();
                hM.rightHapticLoop = currentHapticObject.GetIsLoopable();
                hM.rightHapticStartTime = Time.time;
            }
        }
    }
    private void OnTriggerExit(Collider other) {
        hM.End(controller);
    }
}
