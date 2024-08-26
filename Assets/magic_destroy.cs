using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MagicSkillDestruction : MonoBehaviour
{
    public float lifetime = 5f;  // Duration before the magic skill is destroyed

    void Start()
    {
        // Destroy this game object after 'lifetime' seconds
        Destroy(gameObject, lifetime);
    }
}


