using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codeOfBall : MonoBehaviour
{
    public Text counterText;
    public Text gameOverText;

    
    Rigidbody pyhsical;
    int counter = 0;
    const int targetCount = 13;

    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        pyhsical = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        float verticalMove = Input.GetAxisRaw("Vertical");

        Vector3 movementVector = new Vector3(horizontalMove, 0, verticalMove);

        pyhsical.AddForce(movementVector * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "myTargets")
        {
            other.gameObject.SetActive(false);
            counter++;

            counterText.text = "Score : " + counter;

            if (counter == targetCount)
            {
                gameOverText.text = "    Well Done!";

            }
            
        }
    
    }

}
