using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayControl : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    public void enable() {
        this.gameObject.SetActive(true);
        print("enabled by another object");
    }
    public void disable() {
        this.gameObject.SetActive(false);
        print("disabled by another object");
    }
}
