<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="addNewCustomer._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

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
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="firstName" OnTextChanged="Unnamed1_TextChanged"></asp:TextBox>
                    </div>
                </div>
                <!--Ask for Last Name-->
                <div class="row">
                    <div class="col-md-4">
                        <label>Last Name :</label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="LastName" OnTextChanged="LastName_TextChanged"></asp:TextBox>
                    </div>
                </div>
                <!--Ask for Address-->
                <div class="row">
                    <div class="col-md-4">
                        <label>Address :</label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="address" OnTextChanged="address_TextChanged"></asp:TextBox>
                    </div>
                </div>
                <!--Ask for City-->
                <div class="row">
                    <div class="col-md-4">
                        <label>City/Town :</label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="city" OnTextChanged="city_TextChanged"></asp:TextBox>
                    </div>
                </div>
                <!--Ask for Zip Code-->
                <div class="row">
                    <div class="col-md-4">
                        <label>Zip Code :</label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="zipcode" OnTextChanged="zipcode_TextChanged"></asp:TextBox>
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
                        <asp:TextBox runat="server" CcsClass="list-group-item listItem100" ID="income" OnTextChanged="income_TextChanged"></asp:TextBox>
                    </div>
                </div>
        </div>
    </div>
    <div class="row">
        <asp:Button runat="server" text="Submit" OnClick="Unnamed1_Click"/>
    </div>
    
            

</asp:Content>
