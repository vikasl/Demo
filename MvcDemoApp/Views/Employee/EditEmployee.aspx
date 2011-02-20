<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcDemoApp.Models.Employee>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    EditEmployee
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">

        $(document).ready(function () {
            var editEmployeeProcessor = new employeeProcessor();
            

        }
   );


    </script>
    <h2>
        EditEmployee</h2>
    <% using (Html.BeginForm("EditEmployee", "Employee", FormMethod.Post, new { Id = "EditEmployee" }))
       {%>
    <div class="editEmployeeRow">
        <div class="editEmployeeRowLabel">
            <%=Html.LabelFor(x => x.Fname)%>
        </div>
        <div class="editEmployeeRowTextField">
            <%=Html.TextBoxFor(x => x.Fname)%>
        </div>
    </div>
    <div class="editEmployeeRow">
        <div class="editEmployeeRowLabel">
            <%=Html.LabelFor(x => x.Lname)%>
        </div>
        <div class="editEmployeeRowTextField">
            <%=Html.TextBoxFor(x => x.Lname)%>
        </div>
    </div>
    <div class="editEmployeeRow">
        <div class="editEmployeeRowLabel">
            <%=Html.LabelFor(x => x.Salary)%>
        </div>
        <div class="editEmployeeRowTextField">
            <%=Html.TextBoxFor(x => x.Salary)%>
        </div>
    </div>
    <div class="editEmployeeRow">
        <div class="editEmployeeRowLabel">
            <%=Html.LabelFor(x => x.Sex)%>
        </div>
        <div class="editEmployeeRowTextField">
            <%=Html.TextBoxFor(x => x.Sex)%>
        </div>
    </div>
    <div class="editEmployeeRow">
        <div class="editEmployeeRow">
            <%=Html.LabelFor(x => x.Ssn)%>
        </div>
        <div class="editEmployeeRowTextField">
            <%=Html.TextBoxFor(x => x.Ssn)%>
        </div>
    </div>
    <div id="editEmployeeButtons" class="employeeButtons">
        <div class="saveButton">
            <button id="editEmployeeSave" class="jquery-button" type="submit">
                Save</button>
        </div>
        <div class="cancelButton">
            <button id="editEmployeeCancel" class="jquery-button" onclick="javascript: employeeProcessor.cancelEditEmployee();return false;">
                Cancel</button>
        </div>
    </div>
    <%
       }%>
</asp:Content>
