using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float _restartDelay = 1f;
    [SerializeField] private GameObject _completeLevelUI;

    private bool _gemeHasEnding = false;

    public void CompleteLevel()
    {
        _completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (_gemeHasEnding == false)
        {
            _gemeHasEnding=true;
            Debug.Log("Game Over");
            Invoke("Restart", _restartDelay);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
