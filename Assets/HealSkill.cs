using Gamekit3D;
using UnityEngine;

public class HealSkill : MonoBehaviour
{
    public int Healskill = 1; // Amount of health to heal

    // This method will be called to apply the healing effect
    public void ApplyHealEffect()
    {
        // Find the damageable component on the player
        GameObject damageable = GameObject.FindGameObjectWithTag("Player");
        if (damageable != null)
        {
            // Reset the damageable component's health
            damageable.GetComponent<Damageable>().Healskill(Healskill);        }
        else
        {
            Debug.LogWarning("No Damageable component found to apply heal effect.");
        }
    }
}
