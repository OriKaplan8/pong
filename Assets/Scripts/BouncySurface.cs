
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float ballStrengh;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        BallMovement ball = collision.gameObject.GetComponent<BallMovement>();

        if (ball != null )
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * ballStrengh);
        }
    }
}
