using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorsNextScene : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public void LoadNextScene()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene by incrementing the current scene index
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("");
            Debug.Log("");
            Debug.Log("");
            Debug.Log("");
            Debug.Log("Detected");
            Debug.Log("");
            Debug.Log("");
            Debug.Log("");
            Debug.Log("");
            LoadNextScene();
        }
    }
}
