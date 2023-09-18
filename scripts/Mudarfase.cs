using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mudarfase : MonoBehaviour
{
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { 
        CarregarFase();
        
        }
    }
    private void CarregarFase()
    {
        SceneManager.LoadScene("fase2");
    }





}
