Imports Inventory.TabManager
Imports InventoryData

Public Class Session

    Public Shared MainForm As New frmMain
    Public Shared LoginForm As New frmLogin
    Public Shared ComputerForm As New frmComputers
    Public Shared FurnitureForm As New frmFurniture
    Public Shared EquipmentForm As New frmEquipment
    Public Shared TextbookForm As New frmTextbook
    Public Shared AVForm As New frmAV
    Public Shared MonitorForm As New frmMonitor
    Public Shared PrinterForm As New frmPrinters
    Public Shared SoftwareForm As New frmSoftware
    Public Shared MiscTechForm As New frmMisc
    Public Shared AboutForm As New frmAbout
    Public Shared SupportTicketForm As New frmSubmitTicket
    Public Shared UserManagerForm As New frmUsers
    Public Shared DistrictReportForm As New frmDistrictReport

    Public Shared curUser As New User
    Public Shared curEditUser As New User
    Public Shared curTab As New TabDefinition
    Public Shared curRoom As New Room
    Public Shared curComputer As New Computer
    Public Shared curFurniture As New Furniture
    Public Shared curEquipment As New Equipment
    Public Shared curTextbook As New Textbook
    Public Shared curAV As New AudioVideo
    Public Shared curMonitor As New Monitor
    Public Shared curPrinter As New Printer
    Public Shared curSoftware As New Software
    Public Shared curMiscTech As New MiscTechnology

    Public Shared Users As New List(Of User)
    Public Shared buildings As New List(Of Building)
    Public Shared rooms As New List(Of Room)
    Public Shared Computers As New List(Of Computer)
    Public Shared Furniture As New List(Of Furniture)
    Public Shared Equipment As New List(Of Equipment)
    Public Shared Textbooks As New List(Of Textbook)
    Public Shared AV As New List(Of AudioVideo)
    Public Shared Monitors As New List(Of Monitor)
    Public Shared Printers As New List(Of Printer)
    Public Shared Software As New List(Of Software)
    Public Shared MiscTech As New List(Of MiscTechnology)
    Public Shared PrintManager As New PrintManagement

    Public Shared Context As New InventoryEntities()
End Class
