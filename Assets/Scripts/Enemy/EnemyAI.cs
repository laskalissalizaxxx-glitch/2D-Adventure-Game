/// <summary>
/// Логика поведения противника: патрулирование и атака.
/// </summary>
public class EnemyAI : MonoBehaviour
{
    /// <summary> Расстояние, на котором враг видит игрока. </summary>
    public float detectionRange = 10.0f;

    /// <summary>
    /// Метод для поиска пути к игроку (Pathfinding).
    /// </summary>
    public void Patrol() { }

    /// <summary>
    /// Наносит урон целевому объекту.
    /// </summary>
    /// <param name="damage">Количество здоровья, которое нужно отнять.</param>
    public void Attack(int damage) { }
}
