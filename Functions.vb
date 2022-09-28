

Function FNetsis2Trk(metin As String) As String
FNetsis2Trk = Replace(metin, ChrW(208), ChrW(286))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(220), ChrW(220))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(222), ChrW(350))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(221), ChrW(304))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(214), ChrW(214))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(199), ChrW(199))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(73), ChrW(73))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(240), ChrW(287))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(252), ChrW(252))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(254), ChrW(351))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(105), ChrW(105))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(246), ChrW(246))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(231), ChrW(231))
FNetsis2Trk = Replace(FNetsis2Trk, ChrW(253), ChrW(305))
End Function

Function FTrk2Netsis(metin As String) As String
FTrk2Netsis = Replace(metin, ChrW(286), ChrW(208))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(220), ChrW(220))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(350), ChrW(222))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(304), ChrW(221))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(214), ChrW(214))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(199), ChrW(199))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(73), ChrW(73))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(287), ChrW(240))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(252), ChrW(252))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(351), ChrW(254))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(105), ChrW(105))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(246), ChrW(246))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(231), ChrW(231))
FTrk2Netsis = Replace(FTrk2Netsis, ChrW(305), ChrW(253))
End Function
