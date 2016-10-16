Imports System.IO
Imports System.Threading

Module AttackManaging
    Public Class AttackManager
        Private _targetPath As String
        Private _storagePath As String
        Private _run As Boolean
        Private _attacker As Attacker
        Private _attackThread As Thread
        Private _parser As HashFileParser
        Private _writer As StreamWriter

        ' Statistic
        Private Shared _hashesCracked As Integer

        Public Sub New(ByVal targetPath As String, storagePath As String)
            Me.TargetPath = targetPath
            Me.StoragePath = storagePath
        End Sub

        Public Sub New(ByVal targetPath As String, storagePath As String, attacker As Attacker)
            Me.TargetPath = targetPath
            Me.StoragePath = storagePath
            Me.Attacker = attacker
        End Sub

        ' Makaes use of and manages the attacker's attack method.
        Public Sub attack()
            Dim result As String

            For Each hash In _parser.readHash()
                ' Checks if the thread should still be running
                If _run Then
                    Dim password = Attacker.attack(hash)
                    If password Is Nothing Then
                        result = String.Format("Hash: {0}, Salt: {1}, Status: Uncracked", hash.Hash, hash.Salt)
                    Else
                        _hashesCracked += 1
                        result = String.Format("Password: {0}, Status: Cracked", password)
                    End If
                    _writer.WriteLine(result)
                Else
                    result = String.Format("Hash: {0}, Salt: {1}, Status: Uncracked", hash.Hash, hash.Salt)
                    _writer.WriteLine(result)
                End If
            Next
            _writer.Close()
        End Sub

        ' Starts the attack manager
        Public Sub start()
            ' Initializes input and output files
            _parser = New HashFileParser(TargetPath)
            _writer = New StreamWriter(StoragePath)

            ' Initializes crucial variables
            _hashesCracked = 0
            _run = True

            ' Constructs the thread and starts the attack.
            _attackThread = New Thread(New ThreadStart(AddressOf attack))
            _attackThread.Start()
        End Sub

        ' Stops the thread and its current cracking action.
        Public Sub hault()
            _attacker.Run = False
            _run = False
        End Sub

        ' Class properties
        ' The targeted file that contains hashes.
        Public Property TargetPath As String
            Get
                Return _targetPath
            End Get
            Set(value As String)
                _targetPath = value
            End Set
        End Property

        ' Storage path for output file.
        Public Property StoragePath As String
            Get
                Return _storagePath
            End Get
            Set(value As String)
                _storagePath = value
            End Set
        End Property

        ' The attacker used to commence the attack
        Public Property Attacker As Attacker
            Get
                Return _attacker
            End Get
            Set(value As Attacker)
                _attacker = value
            End Set
        End Property

        ' The number of hashes that have been successfully cracked.
        Public ReadOnly Property HashesCracked As Integer
            Get
                Return _hashesCracked
            End Get
        End Property

        ' The result of the attack thread operating or not.
        Public ReadOnly Property Running As Boolean
            Get
                Return _attackThread.IsAlive
            End Get
        End Property
    End Class
End Module
