'Imports CoreAudio
'Public Class volume_level
'Dim tvalue As Integer
'Private device As MMDevice
'Private Sub volume_level_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'Dim DevEnum As New MMDeviceEnumerator()
'device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
'BunifuVTrackbar1.Value = CInt(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100)
'Timer1.Start()
'tvalue = BunifuVTrackbar1.Value
'End Sub
'
'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
'device.AudioEndpointVolume.MasterVolumeLevelScalar = (CSng(BunifuVTrackbar1.Value) / 100.0F)
'End Sub
'End Class