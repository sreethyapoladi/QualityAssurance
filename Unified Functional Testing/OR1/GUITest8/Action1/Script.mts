systemutil.Run "C:\Program Files (x86)\HP\Unified Functional Testing\samples\Flights Application\FlightsGUI.exe"

Window("HPE MyFlight Sample Applicatio").Click 222,422 @@ hightlight id_;_329622_;_script infofile_;_ZIP::ssf1.xml_;_
Window("HPE MyFlight Sample Applicatio").Dialog("Login Failed").Output CheckPoint("Login Failed") @@ hightlight id_;_1575010_;_script infofile_;_ZIP::ssf2.xml_;_
Window("HPE MyFlight Sample Applicatio").Dialog("Login Failed").WinButton("OK").Click @@ hightlight id_;_787076_;_script infofile_;_ZIP::ssf3.xml_;_
Window("HPE MyFlight Sample Applicatio").Click 224,432 @@ hightlight id_;_329622_;_script infofile_;_ZIP::ssf4.xml_;_
Window("HPE MyFlight Sample Applicatio").Dialog("Login Failed").WinButton("OK").Click @@ hightlight id_;_133616_;_script infofile_;_ZIP::ssf5.xml_;_
Window("HPE MyFlight Sample Applicatio").Close
