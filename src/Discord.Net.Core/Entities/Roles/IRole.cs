﻿using Discord.API.Rest;
using System;
using System.Threading.Tasks;

namespace Discord
{
    public interface IRole : ISnowflakeEntity, IDeletable, IMentionable
    {
        /// <summary> Gets the guild owning this role.</summary>
        IGuild Guild { get; }

        /// <summary> Gets the color given to users of this role. </summary>
        Color Color { get; }
        /// <summary> Returns true if users of this role are separated in the user list. </summary>
        bool IsHoisted { get; }
        /// <summary> Returns true if this role is automatically managed by Discord. </summary>
        bool IsManaged { get; }
        /// <summary> Gets the name of this role. </summary>
        string Name { get; }
        /// <summary> Gets the permissions granted to members of this role. </summary>
        GuildPermissions Permissions { get; }
        /// <summary> Gets this role's position relative to other roles in the same guild. </summary>
        int Position { get; }

        ///// <summary> Modifies this role. </summary>
        Task ModifyAsync(Action<ModifyGuildRoleParams> func, RequestOptions options = null);
    }
}