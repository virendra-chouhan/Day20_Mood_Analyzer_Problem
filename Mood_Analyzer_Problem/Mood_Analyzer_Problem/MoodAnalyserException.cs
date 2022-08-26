﻿using System;
using System.Runtime.Serialization;

namespace Mood_Analyzer_Problem
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUBH_CLASS,
            OBJECT_CREATION_ISSUE
        }

        private readonly ExceptionType type;
        public MoodAnalyserException(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}