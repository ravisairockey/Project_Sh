using Gamekit3D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrenadorUI : MonoBehaviour
{
    public Slider grenadorSlider;

    [SerializeField] private Damageable grenadorDamagable;

    private int currentHealth;
    private int maxHealth;

    private void Start()
    {
        maxHealth = grenadorDamagable.maxHitPoints;
        currentHealth = maxHealth;

        grenadorSlider.value = currentHealth;
    }

    public void UpdateSlider()
    {
        if (currentHealth > 0)
        {
            currentHealth--;
            grenadorSlider.value = currentHealth;
        }
    }
}
