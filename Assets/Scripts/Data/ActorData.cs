using UnityEngine;

[CreateAssetMenu(fileName ="New Actor Data", menuName = "Create Data/New Actor Data")]
public class ActorData : ScriptableObject
{
    public string Name => _name;
    public int Health => _health;
    public float MoveSpeed => _moveSpeed;
    public float RotationSpeed => _rotationSpeed;
    [SerializeField] private string _name;
    [SerializeField] private int _health;
    [SerializeField] private float _moveSpeed; 
    [SerializeField] private float _rotationSpeed;
}
