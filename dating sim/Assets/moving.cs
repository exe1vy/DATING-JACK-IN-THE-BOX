using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    public float moveSpeed;
    public TMP_Text messageText;
    public TMP_Text message;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Xmove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float Zmove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(Xmove, 0, Zmove);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("You have pressed space. Speeding up!" + moveSpeed);
            moveSpeed += 10;
            messageText.text = "Your current text speed is" + moveSpeed.ToString("N0");
            
        }
    }
}
