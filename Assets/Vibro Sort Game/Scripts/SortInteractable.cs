using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortInteractable : HapticInteractable
{
    public ObjectCategory objectCategory = ObjectCategory.Concrete;

    public float[] hapticBuffer_pink = new float[] {
        1f,
        1f,
        1f,
        0f,
        0f,
    };

    public float[] hapticBuffer_red = new float[] {
        1f,
        1f,
        1f,
        0f,
        0f,
        0f,
        1f,
        1f,
        1f,
        0f,
        0f
    };

    public float[] hapticBuffer_yellow = new float[] {
        1f,
        1f,
        1f,
        0f,
        0f,
        1f,
        1f,
        0f,
        0f,
        1f,
        1f,
        0f,
        0f
    };

    public float[] hapticBuffer_green = new float[] {
        1f,
        1f,
        0f,
        0f,
        1f,
        1f,
        0f,
        0f,
        1f,
        1f,
        0f,
        0f,
        1f,
        1f,
        0f,
        0f
    };

    public float[] hapticBuffer_blue = new float[] {
        1f,
        1f,
        0f,
        0f,
        1f,
        1f,
        0f,
        0f,
        1f,
        1f,
        0f,
        0f,
        1f,
        1f,
        0f,
        0f,
        1f,
        1f,
        0f,
        0f
    };

    // Start is called before the first frame update
    void Start()
    {
        UpdateHaptics();   
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHaptics();
    }

    public void UpdateHaptics() {
        switch (objectCategory) {
            case ObjectCategory.Chalky:
                hapticBuffer_amp = hapticBuffer_pink;
                hapticBuffer_freq = hapticBuffer_pink;
                break;
            case ObjectCategory.Concrete:
                hapticBuffer_amp = hapticBuffer_red;
                hapticBuffer_freq = hapticBuffer_red;
                break;
            case ObjectCategory.Squishy:
                hapticBuffer_amp = hapticBuffer_yellow;
                hapticBuffer_freq = hapticBuffer_yellow;
                break;
            case ObjectCategory.Bruisy:
                hapticBuffer_amp = hapticBuffer_green;
                hapticBuffer_freq = hapticBuffer_green;
                break;
            case ObjectCategory.Alien:
                hapticBuffer_amp = hapticBuffer_blue;
                hapticBuffer_freq = hapticBuffer_blue;
                break;
        }
    }

    public ObjectCategory GetCategory() {
        return objectCategory;
    }
}
