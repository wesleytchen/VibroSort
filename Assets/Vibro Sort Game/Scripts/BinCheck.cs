using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BinCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public ObjectCategory binCategory = ObjectCategory.Concrete;
    public Scoreboard sb;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Haptic")) {
            sb.DecreaseObjectsLeft();
            if(other.gameObject.GetComponent<SortInteractable>().GetCategory() == binCategory) {
                sb.IncreaseCorrectScore();
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Haptic")) {
            sb.IncreaseObjectsLeft();
            if(other.gameObject.GetComponent<SortInteractable>().GetCategory() == binCategory) {
                sb.DecreaseCorrectScore();
            }
        }
    }

}
