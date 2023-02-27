using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private PlayerMovement _movement;
    

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            _movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
