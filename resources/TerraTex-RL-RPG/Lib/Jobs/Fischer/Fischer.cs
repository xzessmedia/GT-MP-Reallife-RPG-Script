﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Shared.Math;

namespace TerraTex_RL_RPG.Lib.Jobs.Fischer
{
    class Fischer : IJob
    {
        public void StartJob(Client player)
        {
            // öffne gui im client!
            throw new NotImplementedException();
        }

        public Vector3 GetJobStartPoint()
        {
            // Fischersteg? Wo ist einer?
            return new Vector3(1000,1000,1000);
            //throw new NotImplementedException();
        }

        public void SendJobHelp(Client player)
        {
            player.sendChatMessage(
                "~b~Fischkäufer Karl sagt: Benutz einfach deine Angel mit /startjob und bring mir große Fische. Je größer der Fisch um so mehr lohnt es sich!");
        }

        public string GetAdditionalPickUpJobInfo() => "";

        public bool HasPlayerAllRequirements(Client player)
        {
            //@todo: See #45 - https://github.com/TerraTex-Community/GT-MP-Reallife-RPG-Script/issues/45
            return true;
        }

        public void SendMissingRequirementsToPlayer(Client player)
        {
            //@todo: See #45 - https://github.com/TerraTex-Community/GT-MP-Reallife-RPG-Script/issues/45
        }

        public bool CanPlayerQuitJob(Client player)
        {
            // only if gui is closed!
            throw new NotImplementedException();
        }
    }
}