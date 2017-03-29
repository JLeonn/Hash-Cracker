Namespace StringUtility
    ' Contains multiple prebuilt charactersets that can be used for building salts, and specfic bruteforce attacks.
    Public Module CharacterSets
        Public Const ALL_CHARACTERS As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxy0123456789!@#$%^&*()_+=-[]{};':,.<>/?`~|\ "
        Public Const UPPER_CASES As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Public Const LOWER_CASES As String = "abcdefghijklmnopqrstuvwxyz"
        Public Const NUMBERS As String = "0123456789"
        Public Const SYMBOLS As String = "!@#$%^&*()_+=-[]{};':,.<>/?`~|\"
        Public Const SPACES As String = " "
    End Module
End Namespace