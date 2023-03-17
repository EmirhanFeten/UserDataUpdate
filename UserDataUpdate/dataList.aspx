<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dataList.aspx.cs" Inherits="UserDataUpdate.dataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-12 form-group">
          <a href="registerPage.aspx"><input id="Button4" class="btn btn-lg btn-block btn-warning font-weight-bold my-3 py-2" type="button" value="Register Page" /></a>        
          <a href="loginPage.aspx"><input id="Button3" class="btn btn-lg btn-block btn-warning font-weight-bold my-3 py-2" type="button" value="Login Page" /></a>
        </div>
                    <table class="table table-light table-borderless table-hover text-center mb-0">
                    <thead class="thead-dark">
                        <tr>
                            <th>Row Number</th>
                            <th>First Name</th>
                            <th>Last Name</th>
                            <th>User Name</th>
                            <th>Password</th>
                            <th>Mail</th>     
                            <th>Update</th>     
                        </tr>
                    </thead>
                    <tbody class="align-middle">
                        <%UserDataUpdate.UserCRUD usercrud = new UserDataUpdate.UserCRUD();
                            System.Data.DataTable dt = usercrud.listForUpdate();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            { %>
                        <tr>
                            
                            <td class="align-middle"><%=dt.Rows[i][0] %></td>
                            <td class="align-middle"><%=dt.Rows[i][1] %></td>
                            <td class="align-middle"><%=dt.Rows[i][2] %></td>
                            <td class="align-middle"><%=dt.Rows[i][3] %></td>
                            <td class="align-middle"><%=dt.Rows[i][4] %></td>
                            <td class="align-middle"><%=dt.Rows[i][5] %></td>
                            <td class="align-middle">
                               <a href="updatePage.aspx?sno=<%=dt.Rows[i][0]%>"> <input id="Button2" class="btn btn-sa btn-warning" type="button" value="Udate" /></a>
                            </td>
                               
                        </tr>
                           <% }%> 
                    </tbody>
                </table>
        
           </form>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>

</body>
</html>
