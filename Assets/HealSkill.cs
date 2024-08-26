using Gamekit3D;
using UnityEngine;

public class HealSkill : MonoBehaviour
{
    public float healAmount = 50f; // Amount of health to heal

    // This method will be called to apply the healing effect
    public void ApplyHealEffect()
    {
        // Find the damageable component on the player
        Damageable damageable = FindObjectOfType<Damageable>();
        if (damageable != null)
        {
            // Reset the damageable component's health
            damageable.ResetDamage();
        }
        else
        {
            Debug.LogWarning("No Damageable component found to apply heal effect.");
        }
    }
}
