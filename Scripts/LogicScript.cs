using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
public int playerCoin;
public Text coinText;
public GameObject gameOverScreen;
[ContextMenu("Increase Coin")]
public void addCoin()
{
    playerCoin += 1;
    coinText.text = "Coins : " + playerCoin.ToString();
}

public void restartGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
public void gameOver()
{
    gameOverScreen.SetActive(true);
}
}
