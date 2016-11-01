Imports HashCracker.Backend.Hashing

Namespace HashAttacking
    ' Allows multiple different hash attack methods to be represented as a single entity.
    Public Interface Attacker
        Function attack(ByVal hash As Hash) As String
        Sub resetAttempts()
        ReadOnly Property Attempts As Long
        WriteOnly Property Run As Boolean
    End Interface
End Namespace

