<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="Stock_management.Views.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">  
     <style>
        
        .container-fluid {
            margin-top: 20px;
        }

        
        .form-label {
            display:flex;
            font-weight: bold;
            width:150px;
            padding: 5px 10px 10px 5px;
        }

        
        .form-control {
            width: 500px;
            padding: 10px 20px 20px 20px;
            margin-left: 5%;
            border: 1px solid #ccc;
            border-radius: 4px;
            align-items:center;
        }

        .btn{
            margin-right: 100px;
            margin-top: 20px;
            padding-left: 20px;
            margin-left: 40px;
            
        }
        .text-center{
         margin-left: 20%;
        }

       
.btn-primary {
    background-color: #007bff;
    color: #fff;
    border: none;
    padding: 10px 20px;
    border-radius: 4px;
    cursor: pointer;
}


.btn-primary:hover {
    background-color: #0056b3;
}


.btn-danger {
    background-color: #dc3545;
    color: #fff;
    border: none;
    padding: 10px 20px;
    border-radius: 4px;
    cursor: pointer;
}

.btn-danger:hover {
    background-color: #b5202a;
}


.btn-success {
    background-color: #28a745;
    color: #fff;
    border: none;
    padding: 10px 20px;
    border-radius: 4px;
    cursor: pointer;
}


.btn-success:hover {
    background-color: #1e7e34;
}


        
        
    </style>
    <link href="Stock_management\Assets\Lib\css\bootstrap.min.css" rel="stylesheet" />
    <div class="container-fluid">
        <div class="row">
            <h3 class="text-center">Inventory</h3>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div>
                    <label for="txtTitle1" class="form-label">Item Name</label>
                    <input type="text" id="txtTitle1" class="form-control" />
                </div>
            </div>
            <div class="col-md-4">
                <div>
                    <label for="txtTitle2" class="form-label">Price</label>
                    <input type="text" id="txtTitle2" class="form-control" />
                </div>
            </div>
            <div class="col-md-4">
                <div>
                    <label for="txtTitle3" class="form-label">Quantity</label>
                    <input type="text" id="txtTitle3" class="form-control" />
                </div>
            </div>
            <div class="col-md-4">
                <div>
                    <label for="txtTitle4" class="form-label">Categories</label>
                    <input type="text" id="txtTitle4" class="form-control" />
                </div>
            </div>
            <div class="col-md-12">
                <div class="mt-3">
                    <button class="btn btn-primary" id="btnSave">Save</button>
                    <button class="btn btn-danger" id="btnDelete">Delete</button>
                    <button class="btn btn-success" id="btnUpdate">Update</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

