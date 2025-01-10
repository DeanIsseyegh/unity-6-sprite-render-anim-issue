using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private Animator[] _shapeAnimators;
    
    public void DestroyShapeAnimators()
    {
        foreach (Animator animator in _shapeAnimators)
        {
            Destroy(animator);
        }
    }
}
