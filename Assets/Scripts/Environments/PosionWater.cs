using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class PosionWater : MonoBehaviour
{
    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PosionWater" || collision.tag == "PlatformClose") //if hit platformclose in PlatformClose
        {
            StartCoroutine(Reload());
        }
    }

    private IEnumerator Reload()
    {
        anim.SetTrigger("Die");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
}
 