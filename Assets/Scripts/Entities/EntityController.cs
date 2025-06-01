using UnityEngine;
using UnityEngine.UI;

namespace Entities
{
    public class EntityController : MonoBehaviour
    {
        [SerializeField] private Button CreateEntityButton;
        [SerializeField] private GameObject EntityObject;

        private void Start()
        {
            CreateEntityButton.onClick.AddListener(() => Instantiate(EntityObject, transform));
        }
    }
}