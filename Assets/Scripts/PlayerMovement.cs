using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour

{
    private int count;
    public Text CountText;
    private Rigidbody rb;
    public Text wintext;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        Setcounttext();
        wintext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void FixedUpdate()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(movehorizontal, 0.0f, movevertical);
        rb.AddForce(movement);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coins"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            Setcounttext();
        }
    }
    void Setcounttext()
    {
        CountText.text = "Score: " + count.ToString();
        if (count >= 5)
        {
            SceneManager.LoadScene("winscreen");
        }
    
    }
   
}
