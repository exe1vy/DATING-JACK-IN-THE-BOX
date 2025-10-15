using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class dialougeuforinside : MonoBehaviour
{
    public TextMeshProUGUI componentText;
    public string[] liness;
    public float speedText;
    private int index;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        componentText.text = string.Empty;
        StartDialougue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (componentText.text == liness[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                componentText.text = liness[index];
            }
        }
    }
    void StartDialougue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in liness[index].ToCharArray())
        {
            componentText.text += c;
            yield return new WaitForSeconds(speedText);
        }
    }
    void NextLine()
    {
        if (index < liness.Length - 1)
        {
            index++;
            componentText.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
