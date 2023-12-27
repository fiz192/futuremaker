using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFinder : MonoBehaviour
{
    public void FindAndAdd(int score)
    {
        Player singletonInstance = FindObject<Player>();

        if (singletonInstance != null)
        {
            Debug.Log("Singleton instance found!");
            singletonInstance.AddScore(score);
            // You can now use singletonInstance to access methods and properties of the MySingleton class
        }
        else
        {
            Debug.Log("Singleton instance not found.");
        }
    }

    private T FindObject<T>() where T : Component
    {
        T[] objs = FindObjectsOfType<T>();

        if (objs.Length > 0)
        {
            return objs[0]; // Since it's a singleton, there should only be one
        }
        return null;
    }
}
