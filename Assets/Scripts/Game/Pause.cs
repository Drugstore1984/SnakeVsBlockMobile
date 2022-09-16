
using UnityEngine;

public class Pause : MonoBehaviour
{
    private SnakeMove snakeMove;
    private void Start()
    {
        snakeMove = FindObjectOfType<SnakeMove>();
    }
    public void PauseGame()
    {
        snakeMove.SnakeStop();
    }
    public void ResumeGame()
    {
        snakeMove.SnakeMoveAgain();
    }
}
