using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    [SerializeField] private string TagPlayer= "Player";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == TagPlayer)
        {
            collision.GetComponent<Player>().Death();
        }
    }
}
