using System;
using System.Collections.Generic;
using Castle.Components.DictionaryAdapter;
using PionereeDemo.Friendships.Dto;

namespace PionereeDemo.Chat.Dto;

public class GetUserChatFriendsWithSettingsOutput
{
    public DateTime ServerTime { get; set; }

    public List<FriendDto> Friends { get; set; }

    public GetUserChatFriendsWithSettingsOutput()
    {
        Friends = new EditableList<FriendDto>();
    }
}

