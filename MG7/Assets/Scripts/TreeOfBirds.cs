using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] _birds;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _interactionDistance = 5.0f;

    private void Update()
    {
        foreach (GameObject v in _birds)
        {
            float distance = Vector3.Distance(
                v.transform.position,
                _playerTransform.position
            );

            if (distance <= _interactionDistance)
            {
                v.SetActive(true);
            }
        }
    }
}