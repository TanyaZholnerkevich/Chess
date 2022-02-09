using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu()]
    public class SoundsConfig : ScriptableObject
    {
        [SerializeField] private SoundGroup[] groups;

        public string[] GetGroupsIds()
        {
            return groups.Select(s => s.ID).ToArray();
        }

        public string[] GetSoundsIds(string groupId)
        {
            var group = groups.FirstOrDefault(s => s.ID == groupId);
            return group == null ? null : group.GetIds();
        }

        public SoundInfo GetSoundInfo(string id)
        {
            foreach (var soundGroup in groups)
            {
                var sound = soundGroup.GetSoundInfo(id);
                if (sound != null)
                {
                    return sound;
                }
            }

            return null;
        }
    }
}