using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Count : MonoBehaviour
{
    /* 
    This script has generic current and max counter.
    same script is attached to all jewel and value counters.

    access the text to change and call setCurrentValue() and setMaxValue()
    */
    public int currentValue;
    public int maxValue;
    [SerializeField]
    private TMP_Text _title;
    // Start is called before the first frame update
    void Start()
    {
        currentValue = 0;
        // _title = gameObject.GetComponent<TextMeshPro>();
        UpdateText();
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    private void UpdateText() {
        _title.text = currentValue.ToString() + " / " + maxValue.ToString();
    }

    public void setCurrentValue(int value) {
        currentValue = value;
        UpdateText();
    }
    public void setMaxValue(int value) {
        maxValue = value;
        UpdateText();
    }
}
