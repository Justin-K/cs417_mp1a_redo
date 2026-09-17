using UnityEngine;

public class comet_orbit_script : MonoBehaviour {
    public Transform planet;
    public float gravity;

    public Vector3 initial_velocity;

    private Vector3 velocity;

    void Start() { velocity = initial_velocity; }

    void FixedUpdate() {
        
        Vector3 position = transform.position - planet.position;

        float distance = position.magnitude;

        // Avoid division by zero if the comet hits the center.
        if (distance < 0.001f) { return; }

        Vector3 acceleration = -gravity * position / (distance * distance * distance);

        // Gravity changes velocity.
        velocity += acceleration * Time.fixedDeltaTime;

        // Velocity changes position.
        transform.position += velocity * Time.fixedDeltaTime;
    }
}
