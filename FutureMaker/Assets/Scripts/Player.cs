using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Static instance of the Singleton that will be accessible from anywhere
    public static Player Instance { get; private set; }
    public int score = 0;
    public int passmark = 50;
    public TextMeshProUGUI textMeshProText; // Reference to your TextMeshProUGUI component

    private void OnEnable() 
    {
        textMeshProText.text = $"Score: {score}";
    }
    //Track players

    void Awake()
    {
        // Check if an Instance already exists
        if (Instance == null)
        {
            // If no Instance exists, this becomes the Singleton instance
            Instance = this;
            DontDestroyOnLoad(gameObject); // Makes the object persistent across scenes
        }
        else
        {
            // If an Instance already exists (and it is not this), destroy this instance
            if (Instance != this)
            {
                Destroy(gameObject);
            }
        }

        updateScore();
    }

    public void AddScore(int score)
    {
        this.score += score;
        updateScore();
    }

    // Add your player methods here
    public void Reset()
    {
        // Example method
        score = 0;
        updateScore();
    }

    public void updateScore()
    {
        if(!textMeshProText) return;
        textMeshProText.text = $"Score: {score}";
    }
}