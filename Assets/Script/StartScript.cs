using Unity.VisualScripting;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [ContextMenu("���������� ������")]
    public void Spaw()
    {
        Instantiate(player,transform);
    }
}
