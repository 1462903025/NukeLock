using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using System;

namespace NukeLock.Commands.Subcmds
{
    public class Arm : ICommand
    {
        public string Command { get; } = "arm";
        public string[] Aliases { get; } = { "a" };
        public string Description { get; } = "Arms/Unarms the Alpha Warhead.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("nl.arm"))
            {
                response = "您没有执行此命令的权限。所需权限: nl.arm";
                return false;
            }

            if (!Warhead.LeverStatus)
            {
                Warhead.LeverStatus = true;
                response = "The Alpha Warhead is now armed.";
                return true;
            }

            Warhead.LeverStatus = false;
            response = "The Alpha Warhead is now unarmed.";
            return true;
        }
    }
}
