using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Main1()
    {
        SceneManager.LoadScene("Main");
    }
    public void Main2()
    {
        SceneManager.LoadScene("main2");
    }
    public void Main3()
    {
        SceneManager.LoadScene("main3");
    }
    public void Title()
    {
        SceneManager.LoadScene("Title");
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
