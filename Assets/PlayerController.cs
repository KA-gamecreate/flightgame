using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    float speed = 10.0f;
    public GameObject gameOverCanbas;
    bool gameOver = false;

    public GameObject gameClearCanbas;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            float y = Input.GetAxis("Vertical");
            float x = Input.GetAxis("Horizontal");

            Vector3 velocity = GetComponent<Rigidbody>().velocity;
            velocity.x = x * 10;
            velocity.y = y * 10;
            GetComponent<Rigidbody>().velocity = velocity;

            transform.rotation = Quaternion.AngleAxis(x * -30, Vector3.forward);
        }
            if (transform.position.z >= 150)
            {
            gameClearCanbas.SetActive(true);
            }
        
    }
    void GameOver()
    {
        gameOver = true;
        gameOverCanbas.SetActive(true);
    }
}
