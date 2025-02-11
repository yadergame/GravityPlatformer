using Unity.VisualScripting;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [ContextMenu("Заспавнить игрока")]
    public void Spaw()
    {
        Instantiate(player,transform);
    }
}
