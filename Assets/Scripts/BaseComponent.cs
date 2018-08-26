using UnityEngine;

namespace Turret
{
    /// <summary>
    /// От этого класса наслдеуем все остальные
    /// По мере необходимости дописываем сюда переменные,
    /// которые нужно закэшировать
    /// </summary>
    public class BaseComponent : MonoBehaviour
    {
        private GameObject _gameObject;
        private Transform _transform;

        private void Awake()
        {
            _gameObject = gameObject;
            _transform = transform;
        }
    }
}
