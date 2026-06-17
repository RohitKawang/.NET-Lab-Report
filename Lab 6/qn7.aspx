<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidationDemo.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>ASP.NET Validation Controls Demo</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 40px; }
        .form-group { margin-bottom: 15px; }
        .error { color: red; font-size: 0.9em; display: block; }
        .summary { color: red; margin-top: 20px; font-weight: bold; }
        .success { color: green; font-weight: bold; margin-top: 20px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>User Registration Form</h2>
        <hr />

        <div class="form-group">
            <label>Username:</label><br />
            <asp:TextBox ID="txtUsername" runat="server" />
            <asp:RequiredFieldValidator ID="rfvUsername" runat="server" 
                ControlToValidate="txtUsername" 
                ErrorMessage="Username is required." 
                CssClass="error" Display="Dynamic" />
        </div>

        <div class="form-group">
            <label>Email Address:</label><br />
            <asp:TextBox ID="txtEmail" runat="server" />
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                ControlToValidate="txtEmail" ErrorMessage="Email is required." 
                CssClass="error" Display="Dynamic" />
            <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                ControlToValidate="txtEmail" 
                ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" 
                ErrorMessage="Invalid email format." 
                CssClass="error" Display="Dynamic" />
        </div>

        <div class="form-group">
            <label>Password:</label><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                ControlToValidate="txtPassword" ErrorMessage="Password is required." 
                CssClass="error" Display="Dynamic" />
        </div>

        <div class="form-group">
            <label>Confirm Password:</label><br />
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" />
            <asp:CompareValidator ID="cvPassword" runat="server" 
                ControlToValidate="txtConfirmPassword" 
                ControlToCompare="txtPassword" 
                ErrorMessage="Passwords do not match." 
                CssClass="error" Display="Dynamic" />
        </div>

        <div class="form-group">
            <label>Age (Must be between 18 and 60):</label><br />
            <asp:TextBox ID="txtAge" runat="server" Type="Number" />
            <asp:RangeValidator ID="rvAge" runat="server" 
                ControlToValidate="txtAge" 
                MinimumValue="18" MaximumValue="60" Type="Integer" 
                ErrorMessage="Age must be between 18 and 60." 
                CssClass="error" Display="Dynamic" />
        </div>

        <asp:Button ID="btnSubmit" runat="server" Text="Register" OnClick="btnSubmit_Click" />

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            CssClass="summary" HeaderText="Please fix the following errors:" />

        <asp:Label ID="lblMessage" runat="server" CssClass="success" />
    </form>
</body>
</html>