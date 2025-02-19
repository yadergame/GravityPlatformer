using Unity.VisualScripting;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb;
    [SerializeField]private float Speed;
    public float direction;



    [SerializeField] private float raycastDistance;
    [SerializeField] private LayerMask groundLayer;
    public void Move()
    {

        rb.linearVelocity = new Vector2(direction * Speed, rb.linearVelocity.y);
    }
    public void Use()
    {
        if (OnTheGround())
        {
            rb.gravityScale *= -1;
        }
    }
    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    private bool OnTheGround()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down*rb.gravityScale, raycastDistance, groundLayer);

        return hit.collider != null ;
    }
    private void FixedUpdate()
    {
        Move();
    }


}
