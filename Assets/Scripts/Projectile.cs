using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpringJoint2D springJoint;
    private bool isPressed;
    public bool isAlive;
    public EnemyManager enemyManager;
   
    // Start is called before the first frame update
    void Start()
    {
       
        rb =  GetComponent<Rigidbody2D>();
        springJoint = GetComponent<SpringJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
    private void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }
    private void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
        StartCoroutine(CheckEnemy());
    }
    IEnumerator Release ()
    {
        yield return new WaitForSeconds(0.15f);

        springJoint.enabled = false;
    }
    IEnumerator CheckEnemy ()
    {
        yield return new WaitForSeconds(5f);

        if(enemyManager.IsAnyEnemyAlive())  
        {
            SceneManager.LoadScene("Retry");
        }
        else
        {
            SceneManager.LoadScene("LevelFinished");
        }

    }
}
