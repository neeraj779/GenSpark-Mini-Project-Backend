﻿using System.Runtime.Serialization;

namespace StudentManagementAPI.Exceptions
{
    [Serializable]
    internal class NoClassFoundException : Exception
    {
        string _message;
        public NoClassFoundException()
        {
            _message = "No class found!";
        }
        public override string Message => _message;
    }
}