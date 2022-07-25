﻿using Patterns.Models.Decorator.Interface;

namespace Patterns.Models.Decorator
{
    public class FacebookDecorator : BaseDecorator
    {

        public FacebookDecorator(INotifier wrappee) : base(wrappee)
        {
        }

        public override string GetMessage()
        {
            return $"{Wrappee.GetMessage()} - Facebook";
        }
    }
}
