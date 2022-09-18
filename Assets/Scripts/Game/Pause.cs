
using UnityEngine;

public class Pause : MonoBehaviour
{
    private SnakeMove snakeMove;
    public void PauseGame()
    {
        snakeMove = FindObjectOfType<SnakeMove>();
        snakeMove.SnakeStop();
    }
    public void ResumeGame()
    {
        snakeMove.SnakeMoveAgain();
    }
}
