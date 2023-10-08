using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishGame : MonoBehaviour
{
    public GameObject endGamePanel;
    private void OnTriggerEnter(Collider other)
    {
        endGamePanel.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        endGamePanel.SetActive(true);
    }
}
