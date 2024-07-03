<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Task_7.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="form-group row mb-3">
                <label for="inputName" class="col-sm-2 col-form-label">Name</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="inputName" runat="server" CssClass="form-control" placeholder="Name"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="inputEmail" class="col-sm-2 col-form-label">Email</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="inputEmail" runat="server" CssClass="form-control" TextMode="Email" placeholder="Email"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="inputId" class="col-sm-2 col-form-label">ID</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="inputId" runat="server" CssClass="form-control" placeholder="ID"></asp:TextBox>
                </div>
            </div>
            <fieldset class="form-group mb-3">
                <div class="row">
                    <legend class="col-form-label col-sm-2 pt-0">Gender</legend>
                    <div class="col-sm-10">
                        <div class="form-check">
                            <asp:RadioButton ID="genderMale" runat="server" GroupName="gender" CssClass="form-check-input" />
                            <label class="form-check-label" for="genderMale">Male</label>
                        </div>
                        <div class="form-check">
                            <asp:RadioButton ID="genderFemale" runat="server" GroupName="gender" CssClass="form-check-input" />
                            <label class="form-check-label" for="genderFemale">Female</label>
                        </div>
                    </div>
                </div>
            </fieldset>
            <div class="form-group row mb-3">
                <legend class="col-form-label col-sm-2 pt-0">Skills</legend>
                <div class="col-sm-10">
                    <div class="form-check">
                        <asp:CheckBox ID="skillCpp" runat="server" CssClass="form-check-input" />
                        <label class="form-check-label" for="skillCpp">C++</label>
                    </div>
                    <div class="form-check">
                        <asp:CheckBox ID="skillCsharp" runat="server" CssClass="form-check-input" />
                        <label class="form-check-label" for="skillCsharp">C#</label>
                    </div>
                    <div class="form-check">
                        <asp:CheckBox ID="skillJs" runat="server" CssClass="form-check-input" />
                        <label class="form-check-label" for="skillJs">JavaScript</label>
                    </div>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="comment" class="col-sm-2 col-form-label">Comments</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="comment" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5" placeholder="Comments"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
                <div class="col-sm-10 offset-sm-2">
                    <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="SubmitButton_Click" />
                </div>
            </div>

            <asp:Panel ID="ResultPanel" runat="server" Visible="True">
                <h1 class="mb-4">Submitted Information</h1>
                <div class="mb-3">
                    <label class="form-label"><strong>Name:</strong></label>
                    <asp:Label ID="LabelName" runat="server" CssClass="form-control-static"></asp:Label>
                </div>
                <div class="mb-3">
                    <label class="form-label"><strong>Email:</strong></label>
                    <asp:Label ID="LabelEmail" runat="server" CssClass="form-control-static"></asp:Label>
                </div>
                <div class="mb-3">
                    <label class="form-label"><strong>ID:</strong></label>
                    <asp:Label ID="LabelId" runat="server" CssClass="form-control-static"></asp:Label>
                </div>
                <div class="mb-3">
                    <label class="form-label"><strong>Gender:</strong></label>
                    <asp:Label ID="LabelGender" runat="server" CssClass="form-control-static"></asp:Label>
                </div>
                <div class="mb-3">
                    <label class="form-label"><strong>Skills:</strong></label>
                    <asp:Label ID="LabelSkills" runat="server" CssClass="form-control-static"></asp:Label>
                </div>
                <div class="mb-3">
                    <label class="form-label"><strong>Comments:</strong></label>
                    <asp:Label ID="LabelComments" runat="server" CssClass="form-control-static"></asp:Label>
                </div>
            </asp:Panel>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
