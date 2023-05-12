using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportWorld : MonoBehaviour
{
    [SerializeField] int world;
    string[] worldScenes = {"BlueWorld", "OrangeWorld", "RedWorld", "PinkWorld", "GreyWorld"};

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(worldScenes[world]);
    }
}
