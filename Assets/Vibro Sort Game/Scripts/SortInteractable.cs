using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortInteractable : HapticInteractable
{
    public ObjectCategory objectCategory = ObjectCategory.Concrete;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public ObjectCategory GetCategory() {
        return objectCategory;
    }
}
