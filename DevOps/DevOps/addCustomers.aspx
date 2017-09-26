<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="addCustomers.aspx.cs" Inherits="DevOps.addCustomers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!--Header for AddCustomers Page-->
    <div class="row">
        <div class="col-md-12 welcomeLogo jumbotron ">
            <div class="row">
                <h1>Add Customer Form</h1>
            </div>
        </div>
    </div>

    <!--Form for AddCustomers Page-->
    <div class="row">
        <div class="col-md-10">
            
                <!--Ask for First Name-->
                <div class="row">
                    <div class="col-md-4">
                        <label>First Name :</label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="firstName"></asp:TextBox>
                    </div>
                </div>
                <!--Ask for Last Name-->
                <div class="row">
                    <div class="col-md-4">
                        <label>Last Name :</label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="LastName" ></asp:TextBox>
                    </div>
                </div>
                <!--Ask for Address-->
                <div class="row">
                    <div class="col-md-4">
                        <label>Address :</label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="address" ></asp:TextBox>
                    </div>
                </div>
                <!--Ask for City-->
                <div class="row">
                    <div class="col-md-4">
                        <label>City/Town :</label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="city" ></asp:TextBox>
                    </div>
                </div>
                <!--Ask for Zip Code-->
                <div class="row">
                    <div class="col-md-4">
                        <label>Zip Code :</label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="zipcode" ></asp:TextBox>
                    </div>
                </div>
                <!--Ask for Phone number-->
                <div class="row">
                    <div class="col-md-4">
                        <label>Phone Number :</label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="phone"></asp:TextBox>
                    </div>
                </div>
                <!--Ask for Income-->
                <div class="row">
                    <div class="col-md-4">
                        <label>Annual Income :</label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="income" ></asp:TextBox>
                    </div>
                </div>
            <!--Ask for Email-->
                <div class="row">
                    <div class="col-md-4">
                        <label>Email :</label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="email" ></asp:TextBox>
                    </div>
                </div>
                <!--Submit Info button-->
                <div class="row">
                    <asp:Button ID="addANewRecord" runat="server" Text="Submit" OnClick="addANewRecord_Click" />
                </div>
        </div>
    </div>

</asp:Content>
