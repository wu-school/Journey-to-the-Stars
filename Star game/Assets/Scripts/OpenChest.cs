using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    [SerializeField] GameObject loot; 
    private bool opened;
    // Start is called before the first frame update
    void Start()
    {
        opened = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" && !opened){
            opened = true;
            this.GetComponent<Animator>().SetTrigger("Open");
            Instantiate(loot, new Vector3(this.transform.position.x, this.transform.position.y+1.2f, this.transform.position.z), Quaternion.identity);
        }
    }
}
