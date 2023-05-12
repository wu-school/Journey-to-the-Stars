using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollect : MonoBehaviour
{
    [SerializeField]
    int itemID;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit ingot");
        if (other.gameObject.tag == "Player")
        {
            HeroKnight player = other.gameObject.GetComponent<HeroKnight>();
            switch (itemID)
            {
                case 1:
                    player.item1 = true;
                    break;
                case 2:
                    player.item2 = true;
                    break;
                case 3:
                    player.item3 = true;
                    break;
                case 4:
                    player.item4 = true;
                    break;
                default:
                    player.item5 = true;
                    break;
            }
            Destroy(this.gameObject);
        }
    }
}
