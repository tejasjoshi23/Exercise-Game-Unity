using UnityEngine;
using UnityEngine.UI;

public class HealthBarProgress : MonoBehaviour
{
    public Slider healthSlider; // Reference to your UI Slider component
    public float maxHealth = 100f;
    public float healthIncreaseRate = 10f; // Adjust this value based on how fast you want the health to increase

    private bool isIncreasing = false;

    void Update()
    {
        if (isIncreasing)
        {
            IncreaseHealth();
        }
    }

    public void OnButtonPress()
    {
        isIncreasing = true;
    }

    public void OnButtonRelease()
    {
        isIncreasing = false;
    }

    void IncreaseHealth()
    {
        float newHealth = Mathf.Min(healthSlider.value + healthIncreaseRate * Time.deltaTime, maxHealth);
        healthSlider.value = newHealth;
    }
}



