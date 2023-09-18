using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Morte : MonoBehaviour
{
    public string cena;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CarregarFase();

        }
    }
    private void CarregarFase()
    {
        SceneManager.LoadScene("fase1");
    }
}
//Esse script utiliza o SceneManagement e é apenas um exemplo para uma "morte" do player. 