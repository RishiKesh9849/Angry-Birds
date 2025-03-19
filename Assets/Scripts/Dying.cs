using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dying : MonoBehaviour
{
    public GameObject Bird;
    public GameObject Pattern;
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Destroy();
        }
        if (collision.collider.tag == "Player")
        {
            Destroy();
        }
    }
    public void Destroy()
    {
        Destroy(Bird);
        Instantiate(Pattern, transform.position, Quaternion.identity);
        Score.Instance.AddPoint();
    }
  
}
