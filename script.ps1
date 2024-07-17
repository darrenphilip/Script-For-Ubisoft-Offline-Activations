$url = "https://github.com/darrenphilip/Script-For-Ubisoft-Offline-Activations/blob/main/offlinescript/bin/Release/net8.0/win-x64/offlinescript.exe"
$output = "offlinescript.exe"

# Download the executable
Invoke-WebRequest -Uri $url -OutFile $output

# Run the executable
Start-Process -FilePath $output -NoNewWindow