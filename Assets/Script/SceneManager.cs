using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField]private StartScript StartBlock;
    public Player player;
    [ContextMenu("���������� ������")]
    public void Spawn()
    {
        player = StartBlock.Spawn();
        player.sceneManager=this;
    }
}
