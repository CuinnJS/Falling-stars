using UnityEngine;

public class starterscript : MonoBehaviour
{
    [SerializeField]
    private int Speed;
    [SerializeField]
    private string MyName;
    [SerializeField] 
    private bool MyChoice;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Speed = 3;
        MyChoice = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Speed == 4 && MyChoice == true)
        {
            MyName = "Hello";
        }
        else if (Speed == 3 && MyChoice == false)
        {
            MyName = "Goodbye";
        }
        else
        {
            MyName = "Default";
        }
    }
}
