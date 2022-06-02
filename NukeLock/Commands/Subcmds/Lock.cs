using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using System;

namespace NukeLock.Commands.Subcmds
{
    public class Lock : ICommand
    {
        public string Command { get; } = "lock";
        public string[] Aliases { get; } = { "l" };
        public string Description { get; } = "Locks/Unlocks the Alpha Warhead.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("nl.lock"))
            {
                response = "您没有执行此命令的权限。所需权限: nl.lock";
                return false;
            }

            if (!Warhead.IsLocked)
            {
                Warhead.IsLocked = true;
                response = "The Alpha Warhead is now locked.";
                return true;
            }

            Warhead.IsLocked = false;
            response = "The Alpha Warhead is no longer locked.";
            return true;
        }
    }
}
