using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottonMenu : MonoBehaviour
{
    // Fungsi untuk pindah ke Scene Utama 
    public void SceneUtama ()
    {
        SceneManager.LoadScene (1);
    }

    // Fungsi untuk keluar aplikasi
    public void ExitButton ()
    {
        SceneManager.LoadScene (0);
     Application.Quit ();
     Debug.Log("App Close");
    
    }
    
    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }

    public void AboutButton ()
    {
        SceneManager.LoadScene (2);
    }

    
}