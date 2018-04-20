using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;

public static class Settings
{
    private static ISettings AppSettings =>
      CrossSettings.Current;

    public static bool DisableBack
    {
        get => AppSettings.GetValueOrDefault(nameof(DisableBack), false);
        set => AppSettings.AddOrUpdateValue(nameof(DisableBack), value);
    }

    public static string Token
    {
        get => AppSettings.GetValueOrDefault(nameof(Token), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(Token), value);
    }

    public static int CurrentReport
    {
        get => AppSettings.GetValueOrDefault(nameof(CurrentReport), -1);
        set => AppSettings.AddOrUpdateValue(nameof(CurrentReport), value);
    }

    public static bool CleanDisconnect
    {
        get => AppSettings.GetValueOrDefault(nameof(CleanDisconnect), true);
        set => AppSettings.AddOrUpdateValue(nameof(CleanDisconnect), value);
    }

    public static bool LogoutRequested
    {
        get => AppSettings.GetValueOrDefault(nameof(LogoutRequested), false);
        set => AppSettings.AddOrUpdateValue(nameof(LogoutRequested), value);
    }

    public static string ServerConnectionString
    {
        get => AppSettings.GetValueOrDefault(nameof(ServerConnectionString), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(ServerConnectionString), value);
    }

    public static string ServerName
    {
        get => AppSettings.GetValueOrDefault(nameof(ServerName), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(ServerName), value);
    }

    public static string ConfigName
    {
        get => AppSettings.GetValueOrDefault(nameof(ConfigName), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(ConfigName), value);
    }

    public static string DefaultConfigName
    {
        get => AppSettings.GetValueOrDefault(nameof(DefaultConfigName), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(DefaultConfigName), value);
    }

    public static string Username
    {
        get => AppSettings.GetValueOrDefault(nameof(Username), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(Username), value);
    }

    public static string DefaultUsername
    {
        get => AppSettings.GetValueOrDefault(nameof(DefaultUsername), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(DefaultUsername), value);
    }

    public static string EmpNo
    {
        get => AppSettings.GetValueOrDefault(nameof(EmpNo), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(EmpNo), value);
    }

    public static string EmpName
    {
        get => AppSettings.GetValueOrDefault(nameof(EmpName), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(EmpName), value);
    }

    public static string DeptNo
    {
        get => AppSettings.GetValueOrDefault(nameof(DeptNo), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(DeptNo), value);
    }

    public static string DeptName
    {
        get => AppSettings.GetValueOrDefault(nameof(DeptName), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(DeptName), value);
    }

    public static string SessionID
    {
        get => AppSettings.GetValueOrDefault(nameof(SessionID), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(SessionID), value);
    }

    public static string InfobarMessage
    {
        get => AppSettings.GetValueOrDefault(nameof(InfobarMessage), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(InfobarMessage), value);
    }

    public static int Severity
    {
        get => AppSettings.GetValueOrDefault(nameof(Severity), 0);
        set => AppSettings.AddOrUpdateValue(nameof(Severity), value);
    }

    public static string SiteID
    {
        get => AppSettings.GetValueOrDefault(nameof(SiteID), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(SiteID), value);
    }

    public static int UserPermissions
    {
        get => AppSettings.GetValueOrDefault(nameof(UserPermissions), 0);
        set => AppSettings.AddOrUpdateValue(nameof(UserPermissions), value);
    }

    public static string Role
    {
        get => AppSettings.GetValueOrDefault(nameof(Role), string.Empty);
        set => AppSettings.AddOrUpdateValue(nameof(Role), value);
    }

    public static int DraftCount
    {
        get => AppSettings.GetValueOrDefault(nameof(DraftCount), 0);
        set => AppSettings.AddOrUpdateValue(nameof(DraftCount), value);
    }

    public static int DraftTotal
    {
        get => AppSettings.GetValueOrDefault(nameof(DraftTotal), 0);
        set => AppSettings.AddOrUpdateValue(nameof(DraftTotal), value);
    }

    public static int RejectedCount
    {
        get => AppSettings.GetValueOrDefault(nameof(RejectedCount), 0);
        set => AppSettings.AddOrUpdateValue(nameof(RejectedCount), value);
    }

    public static int RejectedTotal
    {
        get => AppSettings.GetValueOrDefault(nameof(RejectedTotal), 0);
        set => AppSettings.AddOrUpdateValue(nameof(RejectedTotal), value);
    }

    public static int PendingApprovalCount
    {
        get => AppSettings.GetValueOrDefault(nameof(PendingApprovalCount), 0);
        set => AppSettings.AddOrUpdateValue(nameof(PendingApprovalCount), value);
    }

    public static int PendingApprovalTotal
    {
        get => AppSettings.GetValueOrDefault(nameof(PendingApprovalTotal), 0);
        set => AppSettings.AddOrUpdateValue(nameof(PendingApprovalTotal), value);
    }

    public static int PendingPaymentCount
    {
        get => AppSettings.GetValueOrDefault(nameof(PendingPaymentCount), 0);
        set => AppSettings.AddOrUpdateValue(nameof(PendingPaymentCount), value);
    }

    public static int PendingPaymentTotal
    {
        get => AppSettings.GetValueOrDefault(nameof(PendingPaymentTotal), 0);
        set => AppSettings.AddOrUpdateValue(nameof(PendingPaymentTotal), value);
    }
}