$ip = (Get-NetIPAddress -AddressFamily IPv4 | Where-Object {$_.IPAddress -notmatch "127.0.0.1"} | Select-Object -First 1).IPAddress
if (-not $ip) {
    $ip = "localhost"
}

Write-Host "App disponible en: http://$ip:5000"
Write-Host "También responde en: http://localhost:5000"
Write-Host "Presiona Ctrl+C para detenerla."

& "C:\Program Files\dotnet\dotnet.exe" run --urls "http://0.0.0.0:5000"
