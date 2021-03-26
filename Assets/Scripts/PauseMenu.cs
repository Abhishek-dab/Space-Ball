using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public GameObject Pausemenu, Pausebutton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    public void Resume()
    {
        
        Time.timeScale = 1;
        Pausemenu.SetActive(false);
        Pausebutton.SetActive(true);

    }
    public void Pause()
    {
        Pausemenu.SetActive(true);
        Pausebutton.SetActive(false);
        Time.timeScale = 0f;
        
    }
    
}
