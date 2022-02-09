using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu()]
    public class SoundInfo : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private AudioClip clip;
        [SerializeField] private bool loop;
        [Range(0f, 1f)] [SerializeField] private float volume = 1f;
        [Range(0f, 3f)] [SerializeField] private float pitch = 1f;

        public string ID => id;
        public AudioClip Clip => clip;
        public bool Loop => loop;
        public float Volume => volume;
        public float Pitch => pitch;
    }
}