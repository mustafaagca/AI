﻿using Microsoft.Bot.Builder.Solutions.Responses;

namespace ToDoSkill.Dialogs.Shared.Cards
{
    public class TodoItemData : ICardData
    {
        public string CheckIconUrl { get; set; }

        public string Topic { get; set; }
    }
}
