using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject completeLevelUI;
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }

    public void EndGame(){
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            // TODO Restart game or display game over
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
