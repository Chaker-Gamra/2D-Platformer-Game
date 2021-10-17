using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using Cinemachine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    public static Vector2 lastCheckPointPos = new Vector2(-3,0);

    public static int numberOfCoins;
    public TextMeshProUGUI coinsText;

    public CinemachineVirtualCamera VCam;
    public GameObject[] playerPrefabs;
    int characterIndex;

    private void Awake()
    {
        characterIndex =  PlayerPrefs.GetInt("SelectedCharacter", 0);
        GameObject player =  Instantiate(playerPrefabs[characterIndex], lastCheckPointPos, Quaternion.identity);
        VCam.m_Follow = player.transform;
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
        isGameOver = false;
        
    }

    void Update()
    {
        coinsText.text = numberOfCoins.ToString() ;
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
