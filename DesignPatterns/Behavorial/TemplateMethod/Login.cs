﻿namespace DesignPatterns.Behavorial.TemplateMethod
{
    public abstract class Login
    {
        public User User { get; set; }

        public abstract bool SignIn(User user);

        public bool IsAuthenticated() => User != null;

        public User GetUserInformation() => User;
    }
}
