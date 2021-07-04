using UnityEngine;
using UnityEngine.Events;

public class LightBulb : MonoBehaviour
{
    [Header("Positions")]
    [SerializeField] private float _xRange = 3f;
    [SerializeField] private float _yRange = 3f;

    private Vector2 _randomPosition;
    [Space(height: 5f)]

    [Header("Positions")]
    [SerializeField] private UnityEvent _onTap;


    private void Start()
    {
        NewPosition();
    }



    private void NewPosition()
    {
        float xPosition = Random.Range(0 - _xRange, 0 + _xRange);
        float yPosition = Random.Range(0 - _yRange, 0 + _yRange);

        _randomPosition = new Vector2(xPosition, yPosition);

        transform.position = _randomPosition;
    }


    private void OnMouseDown()
    {
        _onTap.Invoke();
    }
}