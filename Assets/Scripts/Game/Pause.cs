using UnityEngine;
public class Pause : MonoBehaviour
{
    private SnakeMove snakeMove;
    [SerializeField] private GameObject _pauseMenu;
    private void OnApplicationPause()
    {
        PauseGame();
    }
    public void PauseGame()
    {
        snakeMove = FindObjectOfType<SnakeMove>();
        snakeMove.SnakeStop();
        _pauseMenu.SetActive(true);
    }
    public void ResumeGame()
    {
        snakeMove.SnakeMoveAgain();
    }
}
