using UnityEngine;
using UnityEngine.InputSystem;
public class break_out_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player_transform;
    public Transform a;
    public Transform b;
    public InputActionReference action;
    private bool break_out;
    void Start() {
        break_out = false;
        action.action.Enable();
        action.action.performed += (ctx) => {
            if (break_out) {
                // Send player back to room
                player_transform.position = a.position;
                player_transform.rotation = a.rotation;
                break_out = false;
            } else {
                // Send player to viewing plane
                player_transform.position = b.position;
                player_transform.rotation = b.rotation;
                break_out = true;
            }
        };
    }

}


