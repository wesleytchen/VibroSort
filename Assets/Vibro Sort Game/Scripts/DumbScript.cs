using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbScript : MonoBehaviour
{

    public Scoreboard scoreboard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider c) {
        // if (c.name == "Start") {
        //     scoreboard.StartGame();
        // } else if (c.name == "End") {
        //     scoreboard.EndGame();
        // }

        if (c.tag == "StartButton") {
            scoreboard.StartGame();
        }
    }
}
