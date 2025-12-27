using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // we can use public gameobject but we only need position of the player so we use transform
    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
