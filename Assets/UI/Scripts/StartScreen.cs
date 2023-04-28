using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public GameObject nextOverlay;
    // Start is called before the first frame update
    void Start()
    {
        // here the start screen is initialized (enabled)
        this.gameObject.SetActive(true);
        // here the game overlays are disabled (performance optimization)
        nextOverlay.GetComponent<OverlayControl>().disable();
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    //called by the play button;
    public void disableScreen() {
        // disables start screen to show game
        this.gameObject.SetActive(false);
        // enables the game overlays
        nextOverlay.GetComponent<OverlayControl>().enable();
    }
}
