﻿using Dependency_injection.Services.Interface;

namespace Dependency_injection.Services
{
    public class YahooServiec : IEmailSender
    {
        // Code for Send Email with Yahoo 
        // these code aren't work for send Email in real it just a sample

        public string SendEmail()
        {
            return "This Email from Aliii with Yahoo.com ";
        }
    }

}
