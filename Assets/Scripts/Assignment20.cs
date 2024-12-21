using UnityEngine;

public class Assignment20 : MonoBehaviour
{
    public float speed = .05f;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, -Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(-Time.deltaTime * speed, 0, 0);
        }




        speed += .02f;


    }
}
