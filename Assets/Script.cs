using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Script : MonoBehaviour
{

    public int counter=0;
    public GameObject cylinder;
    public Text text;
    public float Speed = 5f;
   
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down *5* Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * Speed * Time.deltaTime);
        }



        if (counter <= 0)
        {
            cam.SetActive(true);
            this.gameObject.SetActive(false);
            text.text = "GOOD GAME";
        }
        else
        {
            text.text = "COUNTER = ".ToString() + counter.ToString();
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("RED");
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        counter--;
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("WHITE");
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
        
    }


}
