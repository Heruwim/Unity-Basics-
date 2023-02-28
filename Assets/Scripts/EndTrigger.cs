using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    private void OnTriggerEnter()
    {
        _gameManager.CompleteLevel();
    }
}
