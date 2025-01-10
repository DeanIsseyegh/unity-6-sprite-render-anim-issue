using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public void DestroyAllAnims()
    {
        Animator[] allAnimators = FindObjectsByType<Animator>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        foreach (Animator animator in allAnimators)
        {
            Destroy(animator);
        }
    }
}
