using UnityEngine;
using UnityEngine.SceneManagement; // we use this to load a different scene or reload the scene which we're already on

public class GameManager : MonoBehaviour
{
    // to prevent game ending multiple times we create a boolean variable which checks if the game has already ended or not
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true); // true for enabling and false for disabling
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
            // now we restart the game
            // Restart();
            // we need to add a certain delay to prevent the game from restarting instantly. so we use invoke
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // SceneManager.GetActiveScene().name returns the name of the active scene
        // SceneManager.LoadScene loads the scene with the given name
    }
}
