<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script src="packages/jQuery.3.4.1/Content/Scripts/jquery-3.4.1.min.js"></script>
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <script type="text/javascript">
        function getProducts() {
            $.getJSON("api/Person",
                function (data) {
                    $('#person').empty(); // Clear the table body.

                    // Loop through the list of person.
                    $.each(data, function (key, val) {
                        var row = '<td>' + val.ID + '</td><td>' + val.FullName + '</td><td>' + val.Age + '</td><td class="dropdown">' +
                            '<td class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">' +
                            val.Type + '<span class="caret"></span><ul class="dropdown-menu">' +
                            '<li><a href="#">HTML</a></li>' +
                            '<li><a href="#">CSS</a></li>' +
                            '<li><a href="#">JavaScript</a></li>' +
                            '</ul></td></td>';
                        $('<tr/>', { html: row })  // Append the name.
                            .appendTo($('#person'));
                    });
                });
        }

        $(document).ready(getProducts);
    </script>
    <h2>Products</h2>
    <table class="table table-striped table-bordered">
        <thead >
            <tr>
                <th scope="col">#</th>
                <th scope="col">Name</th>
                <th scope="col">Age</th>
                <th scope="col">Type</th>
            </tr>
        </thead>
        <tbody id="person">
        </tbody>
    </table>
</asp:Content>
