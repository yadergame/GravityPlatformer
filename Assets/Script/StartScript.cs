using Unity.VisualScripting;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [ContextMenu("���������� ������")]
    public Player Spawn()
    {
        return Instantiate(player,transform).GetComponent<Player>();
    }
}
