using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MoveBall ball = collision.gameObject.GetComponent<MoveBall>();

        // null means it collided with something else, it wasn't the ball that it collided with and therefore we don't want to execute many logic 
        // if it's not null, it was the ball and therefore we can do something
        if (ball != null)
        {
            // normal is sort of vector pointing away from the surface at that point 
            // 0 is first colliding 
            Vector2 normal = collision.GetContact(0).normal;
            // add force in the opposite direction to increase speed  
            ball.AddForce(-normal * this.bounceStrength);
        }
    }
}
