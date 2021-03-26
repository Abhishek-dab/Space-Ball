using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemymove : MonoBehaviour
{
    public Transform target;
    Rigidbody myrb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 follow = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        myrb.MovePosition(follow);
        transform.LookAt(target);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
