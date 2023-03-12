using System;

using IVSDKDotNet;
using static IVSDKDotNet.Native.Natives;

namespace RemoveWeaponsOnDeath {
    public class Main : Script {

        #region Constructor
        public Main()
        {
            Tick += Main_Tick;
        }
        #endregion

        private void Main_Tick(object sender, EventArgs e)
        {
            int playerID = CONVERT_INT_TO_PLAYERINDEX(GET_PLAYER_ID());
            GET_PLAYER_CHAR(playerID, out int playerPed);

            if (IS_CHAR_DEAD(playerPed)) REMOVE_ALL_CHAR_WEAPONS(playerPed);
        }

    }
}
