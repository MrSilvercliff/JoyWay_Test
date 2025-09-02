using UnityEngine;

namespace Assets._Project.Scripts.Project.Log
{
    public static class DebugLog 
    {
        public static void Log(object sender, string message)
        {
            var senderName = GetSenderName(sender);
            var log = GenerateLogMessage(senderName, message);
            Log(log);
        }

        public static void Warning(object sender, string message)
        { 
            var senderName = GetSenderName(sender);
            var warning = GenerateLogMessage(senderName, message);
            Warning(warning);
        }

        public static void Error(object sender, string message)
        {
            var senderName = GetSenderName(sender);
            var error = GenerateLogMessage(senderName, message);
            Error(error);
        }

        private static string GenerateLogMessage(string senderName, string message)
        {
            var result = $"[{senderName}] {message}";
            return result;
        }

        private static void Log(string log)
        {
            Debug.Log(log);
        }

        private static void Warning(string warning)
        {
            Debug.LogWarning(warning);
        }

        private static void Error(string error)
        {
            Debug.LogError(error);
        }

        private static string GetSenderName(object sender)
        { 
            var senderType = sender.GetType();
            var result = senderType.Name;
            return result;
        }
    }
}