using UnityEngine;
using UnityEngine.InputSystem;
public class light_switch_script : MonoBehaviour {
    public InputActionReference action;
    private Light light;
    private Color original_color;
    private bool state;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light>();
        original_color = light.color;
        state = false;
        action.action.Enable();
        action.action.performed += (ctx) => {
            if (state) {
                light.color = original_color;
                state = false;
            } else {
                light.color = new Color(23f / 255f, 241f / 255f, 12f / 255f);
                state = true;
            }
        };

    }
}
