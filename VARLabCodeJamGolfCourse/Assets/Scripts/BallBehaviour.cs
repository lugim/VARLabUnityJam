using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallBehaviour : MonoBehaviour
{
    public Rigidbody sphere;
    public Color[] colors = {Color.magenta, Color.blue, Color.green, Color.yellow, Color.red};
    int index;

    private float speed;
    private float horizontalInput;

    bool active;
    bool changeDirection;

    public LineRenderer line;

    private float waitTime = 2.0f;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        active = false;
        changeDirection = true;
        speed = 100f;
        index = 2;


    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");

       
        if (sphere.velocity == new Vector3(0, 0, 0) && changeDirection == false)
        {

            if (timer > waitTime)
            {

                var currentDirection = sphere.transform.rotation;

                sphere.transform.rotation = Quaternion.Euler(currentDirection.x, 0.0f, currentDirection.z);
                timer = 0.0f;
            }

            changeDirection = true;
            line.gameObject.SetActive(true);
            active = false;
  
          

        }



        if (changeDirection == true)
        {

            if (Input.GetKey(KeyCode.V))
            {
                sphere.AddForce(transform.forward * speed);
                active = true;
            }

            setColor();
            transform.Rotate(0, horizontalInput, 0);

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                if (index < 4)
                {
                    speed += 20f;
                    index++;
                }                

            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                if (index > 0)
                {
                    speed -= 20f;                    
                    index--;
                }               

            }
            else if (speed < 0)
            {
                speed = 1f;
            }

            line.gameObject.SetActive(true);

        }

        if (active == true)
        {
            changeDirection = false;
            line.gameObject.SetActive(false);

            timer += Time.deltaTime;

           
        }
    }

    void setColor()
    {
        line.startColor = colors[index];
        line.endColor = colors[index];
    }

}
