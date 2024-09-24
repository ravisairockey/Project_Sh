using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnActiveDestroy : MonoBehaviour

{
    // Public variable to assign the GameObject or prefab to destroy
    public GameObject objectToDestroy;

    // Method to activate the crystal
    public void ActivateCrystal()
    {
        if (objectToDestroy != null)
        {
            Debug.Log("Crystal Activated! Destroying: " + objectToDestroy.name);
            Destroy(objectToDestroy);
        }
        else
        {
            Debug.LogWarning("No object assigned to destroy!");
        }
    }

    // Optional: You can call this method when the crystal is activated in your game logic
    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
        if (isActive)
        {
            ActivateCrystal();
        }
    }
}

