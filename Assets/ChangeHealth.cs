using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHealth : MonoBehaviour
{
    Slider _healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        _healthSlider = GetComponent<Slider>();
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public void SetMaxHealth() {
        _healthSlider.value = _healthSlider.maxValue = maxHealth;
    }

    public void SetHealth(int health) {
        _healthSlider.value = health;
    }
}
