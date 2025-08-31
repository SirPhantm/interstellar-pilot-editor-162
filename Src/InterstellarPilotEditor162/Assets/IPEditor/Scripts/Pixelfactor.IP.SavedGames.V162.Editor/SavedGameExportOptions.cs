using UnityEngine;

namespace Pixelfactor.IP.SavedGames.V162.Editor
{
    public class SavedGameExportOptions : MonoBehaviour
    {
        public bool AutoCreateFleets = true;
        public bool discoverWormholes = true;
        public bool discoverEverything = true;
        public bool discoverEverythingIncludesBandits = false;
        public bool aiDiscoversBandits = false;
    }
}
