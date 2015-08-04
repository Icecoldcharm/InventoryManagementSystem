Imports InventoryData.BusinessObjects

Public Class DistrictReport

    private _User As User
    private _Building as string
    private _Room as Room
    private _AVCount as integer
    private _ComputerCount as integer
    private _EquipmentCount as integer
    private _FurnitureCount as integer
    private _MiscTechCount as integer
    private _MonitorCount as integer
    private _PrinterCount as integer
    private _SoftwareCount as integer
    private _TextbookCount as integer

    Public ReadOnly Property UsersFullName() As String
        Get
            Return _User.FullName
        End Get
    End Property

        Public ReadOnly Property Total() As Integer
        Get
            Return _AVCount + _ComputerCount + _EquipmentCount +
                    _FurnitureCount + _MiscTechCount + _MonitorCount +
                    _PrinterCount + _SoftwareCount + _TextbookCount
        End Get
    End Property

    Public Property TextbookCount() As Integer
        Get
            Return _TextbookCount
        End Get
        Set
            _TextbookCount = Value
        End Set
    End Property

    Public Property SoftwareCount() As Integer
        Get
            Return _SoftwareCount
        End Get
        Set
            _SoftwareCount = Value
        End Set
    End Property

    Public Property PrinterCount() As Integer
        Get
            Return _PrinterCount
        End Get
        Set
            _PrinterCount = Value
        End Set
    End Property

    Public Property MonitorCount() As Integer
        Get
            Return _MonitorCount
        End Get
        Set
            _MonitorCount = Value
        End Set
    End Property

    Public Property MiscTechCount() As Integer
        Get
            Return _MiscTechCount
        End Get
        Set
            _MiscTechCount = Value
        End Set
    End Property

    Public Property FurnitureCount() As Integer
        Get
            Return _FurnitureCount
        End Get
        Set
            _FurnitureCount = Value
        End Set
    End Property

    Public Property EquipmentCount() As Integer
        Get
            Return _EquipmentCount
        End Get
        Set
            _EquipmentCount = Value
        End Set
    End Property

    Public Property ComputerCount() As Integer
        Get
            Return _ComputerCount
        End Get
        Set
            _ComputerCount = Value
        End Set
    End Property

    Public Property AVCount() As Integer
        Get
            Return _AVCount
        End Get
        Set
            _AVCount = Value
        End Set
    End Property

    Public Property Room() As Room
        Get
            Return _Room
        End Get
        Set
            _Room = Value
        End Set
    End Property

    Public Property Building() As String
        Get
            Return _Building
        End Get
        Set
            _Building = Value
        End Set
    End Property

    Public Property User() As User
        Get
            Return _User
        End Get
        Set
            _User = Value
        End Set
    End Property

End Class
