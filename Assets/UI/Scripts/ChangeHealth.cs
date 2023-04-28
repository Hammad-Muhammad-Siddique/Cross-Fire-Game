using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHealth : MonoBehaviour
{
    Slider _healthSlider;
    // public int maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        _healthSlider = GetComponent<Slider>();
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public void SetMaxHealth(int maxHealth) {
        _healthSlider.value = _healthSlider.maxValue = maxHealth;
    }

    // call this function to change health bar
    public void SetHealth(int health) {
        _healthSlider.value = health;
    }
}
