using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit3D;




//public class MagicSkillController : MonoBehaviour
//{
//    [System.Serializable]
//    public class MagicSkill
//    {
//        public string skillName;            // Name of the skill
//        public GameObject magicSkillPrefab; // Reference to the magic prefab
//        public KeyCode keyBind;             // Key to bind the skill
//        public float cooldownTime = 3f;     // Cooldown time in seconds
//        public Transform castPoint;         // Point where the magic will be spawned for this specific skill

//        [HideInInspector]
//        public float cooldownTimer = 0f;   // Timer to track the cooldown
//    }

//    public MagicSkill[] magicSkills;     // Array to hold all magic skills
//    public AudioSource magicSound;       // Optional: AudioSource to play a sound when casting the magic skill

//    void Update()
//    {
//        // Update cooldown timers for all skills
//        foreach (var skill in magicSkills)
//        {
//            if (skill.cooldownTimer > 0)
//            {
//                skill.cooldownTimer -= Time.deltaTime;
//            }
//        }

//        // Check for key presses and cast skills
//        foreach (var skill in magicSkills)
//        {
//            if (Input.GetKeyDown(skill.keyBind) && skill.cooldownTimer <= 0)
//            {
//                CastMagic(skill);
//                skill.cooldownTimer = skill.cooldownTime;  // Reset the cooldown timer
//            }
//        }
//    }

//    void CastMagic(MagicSkill skill)
//    {
//        if (skill.magicSkillPrefab != null && skill.castPoint != null)
//        {
//            // Instantiate the magic skill prefab at the cast point
//            Instantiate(skill.magicSkillPrefab, skill.castPoint.position, skill.castPoint.rotation);

//            // Play the magic sound if available
//            if (magicSound != null)
//            {
//                magicSound.Play();
//            }
//        }
//        else
//        {
//            Debug.LogWarning("MagicSkillPrefab or CastPoint is not assigned for skill: " + skill.skillName);
//        }
//    }
//}



//public class MagicSkillController : MonoBehaviour
//{
//    [System.Serializable]
//    public class MagicSkill
//    {
//        public string skillName;            // Name of the skill
//        public GameObject magicSkillPrefab; // Reference to the magic prefab
//        public KeyCode keyBind;             // Key to bind the skill
//        public float cooldownTime = 3f;     // Cooldown time in seconds
//        public Transform castPoint;         // Point where the magic will be spawned for this specific skill
//        public bool isHealingSkill;         // Flag to differentiate between healing and attacking skills

//        [HideInInspector]
//        public float cooldownTimer = 0f;   // Timer to track the cooldown
//    }

//    public MagicSkill[] magicSkills;     // Array to hold all magic skills
//    public AudioSource magicSound;       // Optional: AudioSource to play a sound when casting the magic skill

//    void Update()
//    {
//        // Update cooldown timers for all skills
//        foreach (var skill in magicSkills)
//        {
//            if (skill.cooldownTimer > 0)
//            {
//                skill.cooldownTimer -= Time.deltaTime;
//            }
//        }

//        // Check for key presses and cast skills
//        foreach (var skill in magicSkills)
//        {
//            if (Input.GetKeyDown(skill.keyBind) && skill.cooldownTimer <= 0)
//            {
//                if (skill.isHealingSkill)
//                {
//                    CastHealSkill(skill);
//                }
//                else
//                {
//                    CastMagic(skill);
//                }
//                skill.cooldownTimer = skill.cooldownTime;  // Reset the cooldown timer
//            }
//        }
//    }

//    void CastMagic(MagicSkill skill)
//    {
//        if (skill.magicSkillPrefab != null && skill.castPoint != null)
//        {
//            // Instantiate the magic skill prefab at the cast point
//            Instantiate(skill.magicSkillPrefab, skill.castPoint.position, skill.castPoint.rotation);

//            // Play the magic sound if available
//            if (magicSound != null)
//            {
//                magicSound.Play();
//            }
//        }
//        else
//        {
//            Debug.LogWarning("MagicSkillPrefab or CastPoint is not assigned for skill: " + skill.skillName);
//        }
//    }

//    void CastHealSkill(MagicSkill skill)
//    {
//        if (skill.magicSkillPrefab != null && skill.castPoint != null)
//        {
//            // Instantiate the healing skill prefab at the cast point
//            GameObject healPrefab = Instantiate(skill.magicSkillPrefab, skill.castPoint.position, skill.castPoint.rotation);

//            // Immediately apply healing effect
//            HealSkill healSkill = healPrefab.GetComponent<HealSkill>();
//            if (healSkill != null)
//            {
//                healSkill.ApplyHealEffect();
//            }

//            // Destroy the healing skill after applying the effect
//            Destroy(healPrefab);

//            // Play the magic sound if available
//            if (magicSound != null)
//            {
//                magicSound.Play();
//            }
//        }
//        else
//        {
//            Debug.LogWarning("MagicSkillPrefab or CastPoint is not assigned for skill: " + skill.skillName);
//        }
//    }
//}



public class MagicSkillController : MonoBehaviour
{
    [System.Serializable]
    public class MagicSkill
    {
        public string skillName;            // Name of the skill
        public GameObject magicSkillPrefab; // Reference to the magic prefab
        public KeyCode keyBind;             // Key to bind the skill
        public float cooldownTime = 3f;     // Cooldown time in seconds
        public Transform castPoint;         // Point where the magic will be spawned for this specific skill
        public bool isHealing;              // Flag to check if the skill is a healing skill

        [HideInInspector]
        public float cooldownTimer = 0f;   // Timer to track the cooldown
    }

    public MagicSkill[] magicSkills;     // Array to hold all magic skills
    public AudioSource magicSound;       // Optional: AudioSource to play a sound when casting the magic skill

    void Update()
    {
        // Update cooldown timers for all skills
        foreach (var skill in magicSkills)
        {
            if (skill.cooldownTimer > 0)
            {
                skill.cooldownTimer -= Time.deltaTime;
            }
        }

        // Check for key presses and cast skills
        foreach (var skill in magicSkills)
        {
            if (Input.GetKeyDown(skill.keyBind) && skill.cooldownTimer <= 0)
            {
                CastMagic(skill);
                skill.cooldownTimer = skill.cooldownTime;  // Reset the cooldown timer
            }
        }
    }

    void CastMagic(MagicSkill skill)
    {
        if (skill.magicSkillPrefab != null && skill.castPoint != null)
        {
            // Instantiate the magic skill prefab at the cast point
            GameObject magicInstance = Instantiate(skill.magicSkillPrefab, skill.castPoint.position, skill.castPoint.rotation);

            // Check if the skill is a healing skill and reset damageable if true
            if (skill.isHealing)
            {
                ApplyHealEffect();
            }

            //// Destroy the magic skill prefab after applying the effect
            //Destroy(magicInstance);

            //// Play the magic sound if available
            //if (magicSound != null)
            //{
            //    magicSound.Play();
            //}
        }
        else
        {
            Debug.LogWarning("MagicSkillPrefab or CastPoint is not assigned for skill: " + skill.skillName);
        }
    }

    void ApplyHealEffect()
    {
        // Find the Damageable component on the player
        Damageable damageable = FindObjectOfType<Damageable>();
        if (damageable != null)
        {
            // Reset the Damageable component's health
            damageable.ResetDamage();
        }
        else
        {
            Debug.LogWarning("No Damageable component found to apply heal effect.");
        }
    }
}




