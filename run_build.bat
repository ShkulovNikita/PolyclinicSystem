chcp 1251
D:
cd "D:\git\PolyclinicSystem"

"C:\Program Files\SonarScanner\SonarScanner.MSBuild.exe" begin /k:"PolyclinicSystemKey" /d:sonar.host.url="http://localhost:9000" /d:sonar.login="14b497af23233fd257c07a7b2ade431eeb79b71d"

"D:\Apps\VisualStudio\MSBuild\Current\Bin\MSBuild.exe" /t:Rebuild

"C:\Program Files\SonarScanner\SonarScanner.MSBuild.exe" end /d:sonar.login="14b497af23233fd257c07a7b2ade431eeb79b71d"

echo "---------------"
echo "Done!"