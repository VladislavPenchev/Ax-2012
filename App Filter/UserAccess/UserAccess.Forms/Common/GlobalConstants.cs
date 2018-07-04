namespace UserAccess.Forms.Common
{
    using System;
    public class GlobalConstants
    {
        public static string MachineName =Environment.MachineName;

        public const int MinimumLengthOfDiscription = 10;
        public const int MaximumLengthOfDiscription = 1000;
        public const int PlaceholderLength = 50;

        public const int CheckBoxIsNotChecked = 0;
        public const int CheckBoxIsChecked = 1;

        public const string NameOfButtonYes = "Yes";
        public const string NameOfButtonNo = "No";
        public const string NameOfButtonSubmit = "Submit";
        public const string NameOfButtonCancel = "Cancel";


        public const string AxFileName = "Ax32.exe";
        public const string AxProcessWork = "Ax32";
        public const string AxFormOpenSYSUSERINFOPAGE = "SysUserInfoPage";
        public const string AxDatabaseNameAppConfig = "AxContext";
        public const string DefaultPassword = "HUVEPHARMA";

        public const string ConnectionStringToAx = @"Data Source={0};Initial Catalog={1};Integrated Security=True";
        public const string ConnectionStringAccessServer = @"Data Source={0};Initial Catalog=AccessServer;Integrated Security=True";

        public const string UpdateCheckBoxTestsWithTrue = "USE {0}; UPDATE USERINFO SET ENABLE = '1' WHERE NAME = '{1}'";
        public const string UpdateCheckBoxTestsWithFalse = "USE {0}; UPDATE USERINFO SET ENABLE = '0' WHERE NAME = '{1}'";
        public const string UpdateLogOutTime = "USE AccessServer; UPDATE UserAccessDbContents SET LogOut = '{0}' WHERE RECID = '{1}'";

        public const string PathAppConfig = "C:\\Program Files (x86)\\Access Microsoft Dynamics AX 2012\\UserAccess.Forms.vshost.exe.config";
        public const string PathAppConfig2 = "C:\\Program Files (x86)\\Access Microsoft Dynamics AX 2012\\UserAccess.Forms.exe.config";
                
        //Messages

        public const string SuccessfullySaved = "Successfully!";
        public const string HaveAccess = "Now you have access to Microsoft Dynamics AX 2012.";
        public const string DescriptionMoreThen10SymbolsOrCanNotEmpty = "Description must be more than 10 symbols or can not be empty!";
        public const string DescriptionCanNotBeMoreThen1000Symbols = "Description can not be more than 1000 symbols!";
        public const string UsernameIsNotValid = "Username is not valid! Contact to IT department.";
        public const string CancelButtnoIsClicedAndDiscriptionIsMoreThan50Symbols = "While Microsoft Dynamics AX 2012 is open , you can not close Access Server!";
        public const string HaveOneAxOpen = "You have an open Microsoft Dynamics AX 2012, you can not open a new Microsoft Dynamics AX 2012!";
        public const string DonNotHaveDatabaseName = "You don't have a database name!";
        public const string WrongPassword = "Password is wrong!";
        public const string FieldDatabaseCanNotBeEmpty = "Field Name Microsoft Dynamics AX 2012 Database  can not be empty!";
        public const string PasswordAreNotTheSame = "Passwords are not the same!";
        public const string FieldPasswordCanNotBeEmpty = "Field Password can not be empty!";
        public const string PlaceholderDescription = "Please, describe the reason for login.";
        public const string AuthenticationNullReferenceError = "Connection string is wrong! Please , go to Development Settings and change it!";
    }
}
