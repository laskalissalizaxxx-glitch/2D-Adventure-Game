/// <summary>
/// Управляет жизненным циклом игры: старт, пауза, уровень.
/// </summary>
public class GameManager : MonoBehaviour
{
    /// <summary> Текущее состояние игры. </summary>
    public bool isPaused = false;

    /// <summary>
    /// Завершает текущий уровень и переключает на следующий.
    /// </summary>
    public void LoadNextLevel() { }

    /// <summary>
    /// Ставит игру на паузу.
    /// </summary>
    public void TogglePause() { }
}
