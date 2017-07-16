using System;

using UnityEngine;

public class AndroidVersion
{
    static AndroidJavaClass versionInfo;

    static AndroidVersion()
    {
        versionInfo = new AndroidJavaClass("android.os.Build$VERSION");
    }

    public static string BASE_OS
    {
        get
        {
            return versionInfo.GetStatic<string>("BASE_OS");
        }
    }

    public static string CODENAME
    {
        get
        {
            return versionInfo.GetStatic<string>("CODENAME");
        }
    }

    public static string INCREMENTAL
    {
        get
        {
            return versionInfo.GetStatic<string>("INCREMENTAL");
        }
    }

    public static int PREVIEW_SDK_INT
    {
        get
        {
            return versionInfo.GetStatic<int>("PREVIEW_SDK_INT");
        }
    }

    public static string RELEASE
    {
        get
        {
            return versionInfo.GetStatic<string>("RELEASE");
        }
    }

    public static string SDK
    {
        get
        {
            return versionInfo.GetStatic<string>("SDK");
        }
    }

    public static int SDK_INT
    {
        get
        {
            return versionInfo.GetStatic<int>("SDK_INT");
        }
    }

    public static string SECURITY_PATCH
    {
        get
        {
            return versionInfo.GetStatic<string>("SECURITY_PATCH");
        }
    }

    public static string ALL_VERSION
    {
        get
        {
            string version = "BASE_OS: " + BASE_OS + "\n";
            version += "CODENAME: " + CODENAME + "\n";
            version += "INCREMENTAL: " + INCREMENTAL + "\n";
            version += "PREVIEW_SDK_INT: " + PREVIEW_SDK_INT + "\n";
            version += "RELEASE: " + RELEASE + "\n";
            version += "SDK: " + SDK + "\n";
            version += "SDK_INT: " + SDK_INT + "\n";
            version += "SECURITY_PATCH: " + SECURITY_PATCH;

            return version;
        }
    }
}
