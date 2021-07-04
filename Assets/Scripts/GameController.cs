using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header ("Camera")]
    [SerializeField] private Camera _camera;
    [Space (height: 5f)]

    [Header("Game Object")]
    [SerializeField] private SpriteRenderer _lightBulb;
    [Space(height: 5f)]

    [Header("End Game")]
    [SerializeField] private GameObject _menu;


    private void Start()
    {
        Time.timeScale = 1;
        
        _lightBulb.enabled = false; 
    }


    public void Tap()
    {
        _menu.SetActive(true);

        _lightBulb.enabled = true;
        _camera.backgroundColor = new Color(0.6933962f, 1f, 0.7789167f);

        Time.timeScale = 0;
    }
}