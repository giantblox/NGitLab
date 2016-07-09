﻿namespace NGitLab.Tests {
    public static class Config {
        public const string ServiceUrl = "http://localhost:1081";
        public const string Secret = "r8pHJ3khRNsNY5yCZ9zK";

        public static GitLabClient Connect() {
            return GitLabClient.Connect(ServiceUrl, Secret);
        }
    }
}