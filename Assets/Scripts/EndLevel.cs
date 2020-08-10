using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public GameObject text;
    public GameObject panel;
    public GameObject secondText;
    public GameObject thirdText;
    public GameObject FourthText;
    public GameObject FifthText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(StartShowingText());
    }

    public IEnumerator StartShowingText()
    {
        panel.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        text.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        secondText.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        thirdText.SetActive(true);  
        yield return new WaitForSeconds(1.5f);
        FifthText.SetActive(true);
        yield return new WaitForSeconds(3f);
        FourthText.SetActive(true);
        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        yield return null;
    }
}
