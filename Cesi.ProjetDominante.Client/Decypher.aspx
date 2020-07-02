<%@ Page Language="C#" Inherits="Cesi.ProjetDominante.Client.Decypher" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Decypher</title>
</head>
<body>
    <h1> CESI Decypher </h1>
    <h2> Decypher page </h2>
    <form id="form1" runat="server">
     
        <div>
            <h4>Select a file to upload:</h4>
   
            <asp:FileUpload id="FileUpload1" runat="server"> </asp:FileUpload>
            <asp:FileUpload id="FileUpload2" runat="server"> </asp:FileUpload>
            <asp:FileUpload id="FileUpload3" runat="server"> </asp:FileUpload>
            <asp:FileUpload id="FileUpload4" runat="server"> </asp:FileUpload>
            <asp:FileUpload id="FileUpload5" runat="server"> </asp:FileUpload>
                
            <br/><br/>
                
            <asp:Button id="UploadButton" Text="Upload file" OnClick="UploadButton_Click" runat="server"> </asp:Button>
       
       <hr />
       
       <asp:Label id="UploadStatusLabel"
           runat="server">
       </asp:Label>        
    </div>
    </form>
</body>
</html>
