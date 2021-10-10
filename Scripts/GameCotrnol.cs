using UnityEngine;
using UnityEngine.SceneManagement;
public class GameCotrnol : MonoBehaviour {

    public static GameCotrnol instance;
    public GameObject gameOverText;
    public bool gameOver = false;
	void Awake () {
		if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy (gameObject);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		if ( gameOver == true && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);// Please reload whatever its open atm
        }
	}
    public void PlayerDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
