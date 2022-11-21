using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticInteractable : MonoBehaviour
{
    public float[] hapticBuffer_amp = new float[] {
        1f,
        1f,
        0f,
        0f,
        0f,
        0.5f,
        1f,
        0.5f,
        0.5f,
        0f,
        0f
    };

    public float[] hapticBuffer_freq = new float[] {
        1f,
        1f,
        0f,
        0f,
        0f,
        0.5f,
        1f,
        0.5f,
        0.5f,
        0f,
        0f
    };

    public bool isLoopableHaptic = false;

    public float[] GetHapticBufferAmplitudes() {
        return hapticBuffer_amp;
    }

    public float[] GetHapticBufferFrequencies() {
        return hapticBuffer_freq;
    }

    public bool GetIsLoopable() {
        return isLoopableHaptic;
    }
}
