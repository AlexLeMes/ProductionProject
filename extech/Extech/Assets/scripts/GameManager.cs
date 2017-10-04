using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject deathMenu;

    public void playerLost()
    {
        deathMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
