using UnityEngine;
public class Pause : MonoBehaviour
{
    private SnakeMove snakeMove;
    [SerializeField] private Game _game;
    [SerializeField] private GameObject _pauseMenu;
    private void OnApplicationPause()
    {
        PauseGame();
    }
    public void PauseGame()
    {
        if (_game.CurrentState == Game.State.Playing)
        {
            snakeMove = FindObjectOfType<SnakeMove>();
            snakeMove.SnakeStop();
            _pauseMenu.SetActive(true);
        }
    }
    public void ResumeGame()
    {
        snakeMove.SnakeMoveAgain();
    }
}
