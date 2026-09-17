using UnityEngine;
using UnityEngine.InputSystem;
public class spawner_script : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject[] prefabs;
    public Vector3[] positions;
    public AudioClip spawn_sound;
    public ParticleSystem spawn_effect;
    public InputActionReference action;
    private int current_index;
    private int n_prefabs;
    void Start() {
        n_prefabs = prefabs.Length;
        current_index = 0;
        if (n_prefabs == 0 || positions.Length == 0 || n_prefabs != positions.Length) { return; }
        action.action.Enable();
        action.action.performed += (ctx) => {
            if (current_index == n_prefabs) { return; }
            else {
                GameObject obj = Instantiate(prefabs[current_index], positions[current_index], Quaternion.identity);
                AudioSource src = obj.AddComponent<AudioSource>();
                src.clip = spawn_sound;
                src.spatialBlend = 0.5f;
                src.Play();
                Instantiate(spawn_effect, positions[current_index], Quaternion.identity);
                current_index++;
            }
            
        };
    }

    // Update is called once per frame
    void Update() {
        
    }
}
