template
========
Jakarta style template and one click deploy (svn, msbuild, nunit, winscp)
========
You need to have the server account first with .NET, e.g.
https://www.tsohost.com/ where you deploy to the public_html folder.

a) Create the folder public_html\HelloWorld.
b) Advanced Management Tools\Secure Shell -> Activate

Then

1)	Check out to the local directory.
2)	Fill in the details in ..\trunk\buildscripts\HelloWorld\ HelloWorld.oneclick 
        <property name="server" value="**.***.**.*" />
        <property name="server.username" value="*****" />
        <property name="server.password" value="******" />
        <property name="server.ssh" value="ssh-rsa **** **:**:**:**:**:**:**:**:**:**:**:**:**:**:**:**" />

3)	Click nant_oneclick.bat, the project will undergo all relevant steps and will be deployed to the server.

Happy deploying

PS. If you are going to set up TSOHOST account, please click TSOHOST on http://www.krzysztofpazowski.com
Thank you

