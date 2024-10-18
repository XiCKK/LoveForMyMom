using System.Collections;
using UnityEngine;

public class GameButton : MonoBehaviour
{
    [SerializeField]
    private GameObject floor;

    private void Start()
    {
        floor.SetActive(false);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Box"))
        {
            floor.SetActive(true);
        }
        else if (collision.tag != ("Box"))
        {
            floor.SetActive(false);

        }
    }
}
